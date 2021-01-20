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
        return connection.Query<Category>("SELECT * FROM \"Categories\"");
      }
    }

    public void Dispose()
    {
      _connection?.Dispose();
    }
  }
}