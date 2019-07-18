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
    public class ClientsController : ControllerBase
    {
        // GET api/clients
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Client1", "Client2" };
        }

        // GET api/clients/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "ClientId";
        }

        // POST api/clients
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/clients/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/clients/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}