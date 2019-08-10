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
    public class ContactsController : ControllerBase
    {
        // GET api/contacts
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Contact1", "Contact2" };
        }

        // GET api/contacts/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "ContactId";
        }

        // POST api/contacts
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/contacts/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/contacts/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}