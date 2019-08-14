using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Services.Entities;

namespace MyWebRecruit.Services.Interfaces
{
    public interface IJobService
    {
        IQueryable<JobDto> GetJobList(ContactDto contact);
        void CreateJob(JobDto jobDto);
        void UpdateJob(JobDto jobDto);
        void DeleteJob(JobDto job);
    }
}
