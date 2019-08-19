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
    public class AssignmentsController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentsController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        // GET api/assignments
        [HttpGet]
        public ActionResult<IEnumerable<AssignmentViewModel>> Get()
        {
            return _assignmentService.GetAssignmentList().Select(entity => Mapper.Map<AssignmentViewModel>(entity)).ToList();
        }

        // GET api/assignments/id
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var entity = _assignmentService.GetAssignment(id);
            return Ok(new ObjectResult(Mapper.Map<AssignmentViewModel>(entity)));
        }

        // POST api/assignments
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/assignments/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/assignments/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}