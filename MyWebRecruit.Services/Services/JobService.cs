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

namespace MyWebRecruit.Services.Services
{
    public class JobService : BaseService, IJobService
    {
        public JobService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }

        public IQueryable<JobDto> GetJobList(ContactDto contact)
        {
            IQueryable<JobDto> jobs;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                jobs = context.JobGeneral.Cast<JobDto>()
                    .Where(x => !x.IsDeleted && x.ContactId == contact.Id)
                    .OrderBy(x => x.Name);
            }
            return jobs;
        }

        public void CreateJob(JobDto jobDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                context.JobGeneral.Add(jobDto.ToData());
                context.SaveChanges();
            }
        }

        public void UpdateJob(JobDto jobDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var jobToUpdate = context.JobGeneral.FirstOrDefault(j => j.Id == jobDto.Id);
                if (jobToUpdate != null)
                {
                    context.JobGeneral.Add(jobDto.ToData());
                    context.SaveChanges();
                }
            }
        }

        public void DeleteJob(JobDto job)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var jobToDelete = context.JobGeneral.FirstOrDefault(j => j.Id == job.Id);
                if (jobToDelete != null)
                {
                    jobToDelete.IsDeleted = true;

                    context.JobGeneral.Update(jobToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
