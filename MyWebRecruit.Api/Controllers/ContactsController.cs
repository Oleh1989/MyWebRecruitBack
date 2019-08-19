using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MyWebRecruit.ViewModels;
using MyWebRecruit.Services.Interfaces;

namespace MyWebRecruit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET api/contacts
        [HttpGet]
        public ActionResult<IEnumerable<ContactViewModel>> Get()
        {
            return _contactService.GetContactList(1).Select(entity => Mapper.Map<ContactViewModel>(entity)).ToList();
        }

        // GET api/contacts/id
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var entity = _contactService.GetContact(id);
            return Ok(new ObjectResult(Mapper.Map<ContactViewModel>(entity)));
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