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
        public void Post([FromBody] string value)
        {

        }

        // PUT api/jobs/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string vslue)
        {

        }

        // DELETE api/jobs/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}