using System.Collections.Generic;
using System.Linq;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace TextOptions.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController : Controller
    {
        private readonly Values _data;

        public SearchController(Values data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return  Ok(_data.texts);
        }
        [HttpGet("{search}")]
        public  ActionResult<List<Values>> Get(string search)
        {
            IEnumerable<ISearch.ISearch> optionValues = _data.texts.Where(o => o.Desc.Contains(search));
            if (optionValues.Count() == 0)
                return NotFound();
            return new ObjectResult(optionValues); 
        }
    }
}