using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MyWebRecruit.ViewModels;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.Services.Entities;

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
        public IActionResult Create(ContactViewModel entity)
        {
            _contactService.ContactCreate(Mapper.Map<ContactDto>(entity));
            return Ok();
        }

        // PUT api/contacts/id
        [HttpPut("{id}")]
        public IActionResult Update(ContactViewModel entity)
        {
            _contactService.UpdateContact(Mapper.Map<ContactDto>(entity));
            return Ok();
        }

        // DELETE api/contacts/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.DeleteContact(id);
            return Ok();
        }
    }
}