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
  [Route("CategoryGroups")]
  public class CategoryGroupController : ControllerBase
  {
    private readonly ILogger<CategoryGroupController> _logger;

    public CategoryGroupController(ILogger<CategoryGroupController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<CategoryGroup> Get()
    {
      return CategoryGroupMock.CategoryGroups;
    }
  }
}
