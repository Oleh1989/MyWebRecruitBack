using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.ViewModels;

namespace MyWebRecruit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserViewModel>> Get()
        {
            return _userService.GetUserList().Select(entity => Mapper.Map<UserViewModel>(entity)).ToList();
        }

        // GET api/users/id
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var entity = _userService.GetUser(id);
            return Ok(new ObjectResult(Mapper.Map<UserViewModel>(entity)));
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