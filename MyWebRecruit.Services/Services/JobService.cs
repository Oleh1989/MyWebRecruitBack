using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.Services.Entities;

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
            using(var context = new MyWebRecruitDataBaseContext())
            {
                jobs = context.JobGeneral.Cast<JobDto>()
                    .Where(x => x.IsDeleted == false && x.ContactId == contact.Id)
                    .OrderBy(x => x.Name);
            }
            return jobs;
        }

        public void CreateJob(int contactId)
        {

        }

        public void UpdateJob(JobDto job)
        {

        }

        public void DeleteJob(JobDto job)
        {

        }        
    }
}
