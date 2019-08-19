using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebRecruit.Services.Entities;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.ViewModels;

namespace MyWebRecruit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET api/clients
        [HttpGet]
        public ActionResult<IEnumerable<ClientViewModel>> Get()
        {
            return _clientService.GetClientList(1).Select(entity => Mapper.Map<ClientViewModel>(entity)).ToList();
        }

        // GET api/clients/id
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var entity = _clientService.GetClient(id);
            return Ok(new ObjectResult(Mapper.Map<ClientViewModel>(entity)));
        }

        // POST api/clients
        [HttpPost]
        public IActionResult Create(ClientViewModel entity)
        {
            _clientService.CreateClient(Mapper.Map<ClientDto>(entity));
            return Ok();
        }

        // PUT api/clients/id
        [HttpPut("{id}")]
        public IActionResult Update(ClientViewModel entity)
        {
            _clientService.UpdateClient(Mapper.Map<ClientDto>(entity));
            return Ok();
        }

        // DELETE api/clients/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clientService.DeleteClient(id);
            return Ok();
        }
    }
}