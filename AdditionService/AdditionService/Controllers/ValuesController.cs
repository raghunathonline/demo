using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
namespace AdditionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       
        
        // GET api/values/5
        [HttpGet]
        public ActionResult<double> Get()
        {
            var queryString = Request.Query;
            StringValues param1; StringValues param2;
            queryString.TryGetValue("p1", out param1);
            queryString.TryGetValue("p2", out param2);
            if(Convert.ToDouble(param1)==0 || Convert.ToDouble(param2)==0)
                return Ok(0);
            return Ok(Convert.ToDouble(param1) + Convert.ToDouble(param2));
        }

    }
}
