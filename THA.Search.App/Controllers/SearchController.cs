using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using THA.Search;

namespace THA.Search.App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController : Controller
    {
        private readonly ISearchService _service;
        public SearchController(ISearchService service)
        {
            _service = service;
        }
        [HttpGet("{search}")]
        public  ActionResult<IEnumerable<Result>> Get(string search)
        {
            if (search is null)
                return NotFound();
            var results = _service.FindResults(search);
                if (results.Count > 0)
                    return Ok(results);
                return NoContent();
        }
    }
}