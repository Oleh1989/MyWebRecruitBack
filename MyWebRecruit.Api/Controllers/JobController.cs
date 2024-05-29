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
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        // GET api/jobs
        [HttpGet]
        public ActionResult<IEnumerable<JobViewModel>> Get()
        {
            return _jobService.GetJobList(1).Select(entity => Mapper.Map<JobViewModel>(entity)).ToList();
        }

        // GET api/jobs/id
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var entity = _jobService.GetJob(id);
            return Ok(new ObjectResult(Mapper.Map<JobViewModel>(entity)));
        }

        // POST api/jobs
        [HttpPost]
        public IActionResult Create(JobViewModel entity)
        {
            _jobService.CreateJob(Mapper.Map<JobDto>(entity));
            return Ok();
        }

        // PUT api/jobs/id
        [HttpPut("{id}")]
        public IActionResult Update(JobViewModel entity)
        {
            _jobService.UpdateJob(Mapper.Map<JobDto>(entity));
            return Ok();
        }

        // DELETE api/jobs/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _jobService.DeleteJob(id);
            return Ok();
        }
    }
}