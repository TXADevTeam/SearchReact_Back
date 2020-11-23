using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using 
namespace TextOptions.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController : Controller
    {
        private readonly Data.Values _data;

        public SearchController(Values data)
        {
            _data = data;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Data.Values>>> Get()
        {
            
            return await _data;
        }
        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<OptionValues>>> Get(string search)
        {
            OptionValues optionValues = await Countries.FirstOrDefaultAsync(u => u.Contains(search));
            if (country is null)
                return NotFound();
            return new ObjectResult(optionValues); 
        }
    }
}