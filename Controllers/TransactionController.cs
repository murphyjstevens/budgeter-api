using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgeterApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BudgeterApi.Mocks;

namespace BudgeterApi.Controllers
{
  [ApiController]
  [Route("Transactions")]
  public class TransactionController : ControllerBase
  {
    private readonly ILogger<TransactionController> _logger;

    public TransactionController(ILogger<TransactionController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("Account/{accountId}")]
    public IEnumerable<Transaction> Get(int accountId)
    {
      return TransactionMock.Transactions.Where(transaction => transaction.AccountId == accountId);
    }
  }
}
