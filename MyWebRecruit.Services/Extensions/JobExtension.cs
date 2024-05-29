using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Extensions
{
    public static class JobExtension
    {
        public static JobDto ToDto(this JobGeneral job)
        {
            if (job == null)
                return null;

            var jobDto = new JobDto
            {
                AddressCity = job.AddressCity,
                AddressIndex = job.AddressIndex,
                AddressLine = job.AddressLine,
                Category = job.Category,
                Country = job.CountryNavigation.CountryName,
                CountryId = job.CountryId.Value,
                EndDt = job.EndDt,
                Id = job.Id,
                IntershipYn = job.IntershipYn.Value,
                JobCurrency = job.JobCurrency,
                JobStatus = job.JobStatus,
                Name = job.Name,
                NoReq = job.NoReq,
                PayMethod = job.PayMethod,
                Salary = job.Salary,
                StartDt = job.StartDt
                //ContactId
            };

            return jobDto;
        }

        public static JobGeneral ToData(this JobDto jobDto)
        {
            if (jobDto == null)
                return null;

            var job = new JobGeneral
            {
                AddressCity = jobDto.AddressCity,
                AddressIndex = jobDto.AddressIndex,
                AddressLine = jobDto.AddressLine,
                Category = jobDto.Category,
                Country = jobDto.Country,
                CountryId = jobDto.CountryId.Value,
                EndDt = jobDto.EndDt,
                Id = jobDto.Id.Value,
                IntershipYn = jobDto.IntershipYn.Value,
                JobCurrency = jobDto.JobCurrency,
                JobStatus = jobDto.JobStatus,
                Name = jobDto.Name,
                NoReq = jobDto.NoReq,
                PayMethod = jobDto.PayMethod,
                Salary = jobDto.Salary,
                StartDt = jobDto.StartDt
                //ContactId
            };

            return job;
        }
    }
}
