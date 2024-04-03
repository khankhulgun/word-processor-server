using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2DocumentEditorServer.Controllers
{
    [Route("word/api/[controller]")]
    public class TestController : Controller
    {
        // GET word/api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET word/api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST word/api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT word/api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE word/api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
