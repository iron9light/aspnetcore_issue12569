using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

namespace aspnetcorebug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ValueB>> Get()
        {
            var valueAs = Enumerable.Range(0, 10).Select(x => new ValueA { Value = x }).ToList();
            return new ActionResult<IEnumerable<ValueB>>(valueAs.Select(x => new ValueB { Value = x.Value }));
        }
    }

    public class ValueA
    {
        public int Value { get; set; }
    }

    public class ValueB
    {
        public int Value { get; set; }
    }
}
