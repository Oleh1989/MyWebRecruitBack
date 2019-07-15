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
    public class AssignmentsController : ControllerBase
    {
        // GET api/assignments
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Assignment1", "Assignment2" };
        }

        // GET api/assignments/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "AssignmentId";
        }

        // POST api/assignments
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/assignments/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/assignments/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}