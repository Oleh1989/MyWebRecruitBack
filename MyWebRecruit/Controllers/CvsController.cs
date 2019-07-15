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
    public class CvsController : ControllerBase
    {
        // GET api/cvs
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Cv1", "Cv2" };
        }

        // GET api/cvs/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "CvId";
        }

        // POST api/cvs
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/cvs/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/cvs/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}