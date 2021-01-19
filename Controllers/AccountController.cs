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
  [Route("Accounts")]
  public class AccountController : ControllerBase
  {
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Account> Get()
    {
      return AccountMock.Accounts;
    }

    [HttpGet]
    [Route("Url/{url}")]
    public Account Find(string url) 
    {
      return AccountMock.Accounts.FirstOrDefault(account => string.Equals(account.Url, url));
    }
  }
}
