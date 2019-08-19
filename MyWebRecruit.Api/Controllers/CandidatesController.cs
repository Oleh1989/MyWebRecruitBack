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
    public class CandidatesController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        // GET api/candidates
        [HttpGet]
        public ActionResult<IEnumerable<CandidateViewModel>> Get()
        {
            return _candidateService.GetCandidateList(1).Select(entity => Mapper.Map<CandidateViewModel>(entity)).ToList();
        }

        // GET api/candidates/id
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var entity = _candidateService.GetCandidate(id);
            return Ok(new ObjectResult(Mapper.Map<CandidateViewModel>(entity)));
        }

        // POST api/candidates
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/candidates/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/candidates/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}