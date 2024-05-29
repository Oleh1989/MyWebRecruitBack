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
        public IActionResult Create(AssignmentViewModel entity)
        {
            _assignmentService.CreateAssignment(Mapper.Map<AssignmentDto>(entity));
            return Ok();
        }

        // PUT api/assignments/id
        [HttpPut("{id}")]
        public IActionResult Update(AssignmentViewModel entity)
        {
            _assignmentService.UpdateAssignment(Mapper.Map<AssignmentDto>(entity));
            return Ok();
        }

        // DELETE api/assignments/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _assignmentService.DeleteAssignment(id);
            return Ok();
        }
    }
}