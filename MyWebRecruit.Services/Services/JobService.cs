using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.Services.Entities;
using MyWebRecruit.Services.Extensions;
using MyWebRecruit.Data.UnitOfWorks;

namespace MyWebRecruit.Services.Services
{
    public class JobService : BaseService, IJobService
    {
        public JobService(IUnitOfWork uow) : base(uow)
        {

        }

        public List<JobDto> GetJobList(int contactId)
        {
            return _uow.JobRepository.GetAll()
                .Where(x => x.ContactId == contactId)
                .Select(x => x.ToDto()).ToList();
        }

        public JobDto GetJob(int id)
        {
            return _uow.JobRepository.GetById(id).ToDto();
        }

        public void CreateJob(JobDto jobDto)
        {
            _uow.JobRepository.Add(jobDto.ToData());
            _uow.Save();
        }

        public void UpdateJob(JobDto jobDto)
        {
            _uow.JobRepository.Update(jobDto.ToData());
            _uow.Save();
        }

        public void DeleteJob(int id)
        {
            _uow.JobRepository.Delete(id);
            _uow.Save();
        }
    }
}
