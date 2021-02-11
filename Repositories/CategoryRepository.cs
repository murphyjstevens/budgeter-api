using Dapper;
using Npgsql;
using System.Collections.Generic;
using BudgeterApi.Models;

namespace BudgeterApi.Repositories
{
  public interface ICategoryRepository
  {
    IEnumerable<Category> Get();
    IEnumerable<Category> GetSimple();
  }
  public class CategoryRepository : CoreRepository, ICategoryRepository
  {
    private const string RETURN_OBJECT = "id, name, budget, category_group_id AS CategoryGroupId";
    private NpgsqlConnection _connection;

    public CategoryRepository()
    {
      _connection = new NpgsqlConnection(ConnectionString);
      _connection.Open();
    }

    public IEnumerable<Category> Get()
    {
      using (var connection = new NpgsqlConnection(ConnectionString)) {
        connection.Open();
        return connection.Query<Category>(
          $@"SELECT c.id, c.name, c.budget, c.category_group_id as CategoryGroupId, coalesce(SUM(t.cost), 0::money) as Spent FROM categories c
LEFT JOIN transactions t ON t.category_id = c.id
GROUP BY c.id, c.name, c.budget, c.category_group_id");
      }
    }

    public IEnumerable<Category> GetSimple()
    {
      using (var connection = new NpgsqlConnection(ConnectionString)) {
        connection.Open();
        return connection.Query<Category>($"SELECT {RETURN_OBJECT} FROM categories");
      }
    }

    public void Dispose()
    {
      _connection?.Dispose();
    }
  }
}