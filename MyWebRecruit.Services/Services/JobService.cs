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
            using (var context = new MyWebRecruitDataBaseContext())
            {
                jobs = context.JobGeneral.Cast<JobDto>()
                    .Where(x => x.IsDeleted == false && x.ContactId == contact.Id)
                    .OrderBy(x => x.Name);
            }
            return jobs;
        }

        public void CreateJob(int contactId)
        {
            string nameDummy = string.Empty;
            string addressLineDummy = string.Empty, addressCityDummy = string.Empty,
                addressIndexDummy = string.Empty;
            string jobCurrencyDummy = string.Empty;
            string jobStatusDummy = string.Empty;
            DateTime startDateDummy = DateTime.Now, endDateDummy = DateTime.Now;
            short noReqDummy = 0;
            string categoryDummy = string.Empty;
            decimal salaryDummy = 0;
            byte intershipYNDummy = 0;
            int payMethodDummy = 0;

            using (var context = new MyWebRecruitDataBaseContext())
            {
                var newJob = new JobGeneral
                {
                    Name = nameDummy,
                    AddressLine = addressLineDummy,
                    AddressCity = addressCityDummy,
                    AddressIndex = addressIndexDummy,
                    JobCurrency = jobCurrencyDummy,
                    JobStatus = jobStatusDummy,
                    StartDt = startDateDummy,
                    EndDt = endDateDummy,
                    NoReq = noReqDummy,
                    Category = categoryDummy,
                    Salary = salaryDummy,
                    IntershipYn = intershipYNDummy,
                    PayMethod = payMethodDummy
                };

                context.JobGeneral.Add(newJob);
                context.SaveChanges();
            }
        }

        public void UpdateJob(JobDto job)
        {
            string nameDummy = string.Empty;
            string addressLineDummy = string.Empty, addressCityDummy = string.Empty,
                addressIndexDummy = string.Empty;
            string jobCurrencyDummy = string.Empty;
            string jobStatusDummy = string.Empty;
            DateTime startDateDummy = DateTime.Now, endDateDummy = DateTime.Now;
            short noReqDummy = 0;
            string categoryDummy = string.Empty;
            decimal salaryDummy = 0;
            byte intershipYNDummy = 0;
            int payMethodDummy = 0;

            using (var context = new MyWebRecruitDataBaseContext())
            {
                var jobToUpdate = context.JobGeneral.FirstOrDefault(j => j.Id == job.Id);
                if (jobToUpdate != null)
                {
                    jobToUpdate.Name = nameDummy;
                    jobToUpdate.AddressLine = addressLineDummy;
                    jobToUpdate.AddressCity = addressCityDummy;
                    jobToUpdate.AddressIndex = addressIndexDummy;
                    jobToUpdate.JobCurrency = jobCurrencyDummy;
                    jobToUpdate.JobStatus = jobStatusDummy;
                    jobToUpdate.StartDt = startDateDummy;
                    jobToUpdate.EndDt = endDateDummy;
                    jobToUpdate.NoReq = noReqDummy;
                    jobToUpdate.Category = categoryDummy;
                    jobToUpdate.Salary = salaryDummy;
                    jobToUpdate.IntershipYn = intershipYNDummy;
                    jobToUpdate.PayMethod = payMethodDummy;

                    context.JobGeneral.Add(jobToUpdate);
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
