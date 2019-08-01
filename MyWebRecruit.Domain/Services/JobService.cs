using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyWebRecruit.Data;
using MyWebRecruit.Data.MyWebRecruit.Data.Entities;
using MyWebRecruit.Domain.Extensions;
using MyWebRecruit.Domain.Models;

namespace MyWebRecruit.Domain.Services
{
    public interface IJobService
    {
        List<JobDto> GetJobs();
    }
    public class JobService : IJobService
    {
        public List<JobDto> GetJobs()
        {
            var list = new List<JobGeneral>();

            return list
                        .Select(j => j.ToDto())
                        .ToList();
        }
    }
}
