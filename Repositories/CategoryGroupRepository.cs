using Dapper;
using Npgsql;
using System.Collections.Generic;
using BudgeterApi.Models;

namespace BudgeterApi.Repositories
{
  public interface ICategoryGroupRepository
  {
    IEnumerable<CategoryGroup> Get();
  }
  public class CategoryGroupRepository : CoreRepository, ICategoryGroupRepository
  {
    public IEnumerable<CategoryGroup> Get()
    {
      using (var connection = new NpgsqlConnection(ConnectionString)) {
        connection.Open();
        return connection.Query<CategoryGroup>("SELECT * FROM category_groups");
      }
    }
  }
}