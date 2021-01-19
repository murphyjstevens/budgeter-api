using System.Linq;
using System.Collections.Generic;
using BudgeterApi.Models;
using System;

namespace BudgeterApi.Mocks 
{
  public static class TransactionMock 
  {
    public static IEnumerable<Transaction> Transactions = new List<Transaction> 
    {
      new Transaction 
      { 
        Id = 1, 
        AccountId = 1, 
        Date = DateTime.Now, 
        Cost = 40.00m, 
        To = "McDonalds", 
        CategoryId = 1 
      },
      new Transaction 
      { 
        Id = 2, 
        AccountId = 1, 
        Date = DateTime.Now, 
        Cost = 12.23m, 
        To = "Burger King", 
        CategoryId = 1 
      },
      new Transaction 
      { 
        Id = 3, 
        AccountId = 1, 
        Date = DateTime.Now, 
        Cost = 50.91m, 
        To = "McDonalds", 
        CategoryId = 1 
      },
      new Transaction 
      { 
        Id = 4, 
        AccountId = 1, 
        Date = DateTime.Now, 
        Cost = 5.11m, 
        To = "McDonalds", 
        CategoryId = 1 
      },
      new Transaction 
      { 
        Id = 5, 
        AccountId = 1, 
        Date = DateTime.Now, 
        Cost = 2980.82m, 
        To = "Walmart", 
        CategoryId = 1 
      },
      new Transaction 
      { 
        Id = 6, 
        AccountId = 2, 
        Date = DateTime.Now, 
        Cost = 40.00m, 
        To = "Cub Foods", 
        CategoryId = 1 
      },
      new Transaction 
      { 
        Id = 7, 
        AccountId = 2, 
        Date = DateTime.Now, 
        Cost = 12.23m, 
        To = "KFC", 
        CategoryId = 1 
      }
    };
  }
}