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
        List<JobDto> GetJobList(int contactId);
        JobDto GetJob(int id);
        void CreateJob(JobDto jobDto);
        void UpdateJob(JobDto jobDto);
        void DeleteJob(int id);
    }
}
