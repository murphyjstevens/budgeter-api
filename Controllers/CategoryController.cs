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
  [Route("Categories")]
  public class CategoryController : ControllerBase
  {
    private readonly ILogger<CategoryController> _logger;

    public CategoryController(ILogger<CategoryController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Category> Get()
    {
      return CategoryMock.Categories;
    }
  }
}
