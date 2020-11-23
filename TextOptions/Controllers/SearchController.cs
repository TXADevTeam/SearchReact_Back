using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Get()
        {
            return  Ok(_data.texts);
        }
        [HttpGet("{search}")]
        public  ActionResult<List<Data.Values>> Get(string search)
        {
      //      Text optionValues =  _data.texts.FirstOr;
      //      if (optionValues is null)
                return NotFound();
      //      return new ObjectResult(optionValues); 
        }
    }
}