using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebRecruit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "User1", "User2" };
        }

        // GET api/users/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "UserId";
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/users/id
        [HttpPut("{id}")]
        public void Post(int id, [FromBody] string value)
        {

        }

        // DELETE api/users/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}