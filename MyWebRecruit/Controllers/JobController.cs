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
    public class JobController : ControllerBase
    {
        // GET api/jobs
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Job1", "Job2" };
        }

        // GET api/jobs/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "JobId";
        }

        // POST api/jobs
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/jobs/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string vslue)
        {

        }

        // DELETE api/jobs/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}