using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebRecruit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalsController : ControllerBase
    {
        // GET api/journals
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Journal1", "Journal2" };
        }

        // GET api/journals/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "JournalId";
        }

        // POST api/journals
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/journals/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/journals/id
        [HttpDelete("id")]
        public void Delete(int id)
        {

        }
    }
}