using Dapper;
using Npgsql;
using System.Collections.Generic;
using BudgeterApi.Models;

namespace BudgeterApi.Repositories
{
  public interface ITransactionRepository
  {
    IEnumerable<Transaction> GetByAccount(int accountId);
    IEnumerable<Transaction> GetByCategory(int categoryId);
  }
  public class TransactionRepository : CoreRepository, ITransactionRepository
  {
    public IEnumerable<Transaction> GetByAccount(int accountId)
    {
      using (var connection = new NpgsqlConnection(ConnectionString)) {
        connection.Open();
        return connection.Query<Transaction>("SELECT * FROM \"Transactions\" WHERE \"AccountId\" = @AccountId", new { AccountId = accountId });
      }
    }

    public IEnumerable<Transaction> GetByCategory(int categoryId)
    {
      using (var connection = new NpgsqlConnection(ConnectionString)) {
        connection.Open();
        return connection.Query<Transaction>("SELECT * FROM \"Transactions\" WHERE \"CategoryId\" = @CategoryId", new { CategoryId = categoryId });
      }
    }
  }
}