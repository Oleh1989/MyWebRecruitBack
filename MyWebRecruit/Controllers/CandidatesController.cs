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
    public class CandidatesController : ControllerBase
    {
        // GET api/candidates
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Candidate1", "Candidate2" };
        }

        // GET api/candidates/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "CandidateId";
        }

        // POST api/candidates
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/candidates/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/candidates/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}