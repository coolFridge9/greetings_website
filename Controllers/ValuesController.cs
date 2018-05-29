using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Greeting_Website.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
			var dateTime = getDateTime();
			return "Hello Jordan\n" + dateTime;
        }

		private string getDateTime()
		{
			var dateTime = DateTime.Now;
			return dateTime.ToString("h:mmtt on dd MMMM yyyy");
		}

		// GET api/values/5
		[HttpGet("{id}")]
        public string Get(int id)
        {
			return "Hello!\n"+getDateTime();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
