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
        public IActionResult Create(JobViewModel entity)
        {
            _userService.CreateUser(Mapper.Map<UserDto>(entity));
            return Ok();
        }

        // PUT api/users/id
        [HttpPut("{id}")]
        public IActionResult Update(JobViewModel entity)
        {
            _userService.UpdateUser(Mapper.Map<UserDto>(entity));
            return Ok();
        }

        // DELETE api/users/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }
    }
}