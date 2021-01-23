using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using BudgeterApi.Models;

namespace BudgeterApi.Repositories
{
  public interface ICategoryRepository
  {
    IEnumerable<Category> Get();
  }
  public class CategoryRepository : CoreRepository, ICategoryRepository
  {
    private const string RETURN_OBJECT = "id, name, budget, spent, category_group_id AS CategoryGroupId";
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
        return connection.Query<Category>($"SELECT {RETURN_OBJECT} FROM categories");
      }
    }

    public void Dispose()
    {
      _connection?.Dispose();
    }
  }
}