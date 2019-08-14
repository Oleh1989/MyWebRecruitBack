using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Extensions
{
    public static class CandidateExtension
    {
        public static CandidateDto ToDto(this Candidate candidate)
        {
            if (candidate == null)            
                return null;

            var candidateDto = new CandidateDto
            {
                Id = candidate.Id,
                FirstName = candidate.FirstName,
                LastName = candidate.LastName,
                MiddleName = candidate.MiddleName,
                Email = candidate.Email,
                TelNo = candidate.TelNo,
                AlterTelNo = candidate.AlterTelNo,
                DisturbYn = candidate.DisturbYn.Value,
                Facebook = candidate.Facebook,
                Linkedin = candidate.Linkedin,
                Skype = candidate.Skype,
                Dob = candidate.Dob.Value,
                Age = candidate.Age.Value,
                CreatedBy = candidate.CreatedBy,
                AddressLine = candidate.AddressLine,
                AddressCity = candidate.AddressLine,
                AddressIndex = candidate.AddressLine,
                CountryId = candidate.CountryId.Value,
                Country = candidate.Country.CountryName
            };

            return candidateDto;
        }

        public static Candidate ToData(this CandidateDto candidateDto)
        {
            if (candidateDto == null)
                return null;

            var candidate = new Candidate
            {
                Id = candidateDto.Id.Value,
                FirstName = candidateDto.FirstName,
                LastName = candidateDto.LastName,
                MiddleName = candidateDto.MiddleName,
                Email = candidateDto.Email,
                TelNo = candidateDto.TelNo,
                AlterTelNo = candidateDto.AlterTelNo,
                DisturbYn = candidateDto.DisturbYn.Value,
                Facebook = candidateDto.Facebook,
                Linkedin = candidateDto.Linkedin,
                Skype = candidateDto.Skype,
                Dob = candidateDto.Dob.Value,
                Age = candidateDto.Age.Value,
                CreatedBy = candidateDto.CreatedBy,
                AddressLine = candidateDto.AddressLine,
                AddressCity = candidateDto.AddressLine,
                AddressIndex = candidateDto.AddressLine,
                CountryId = candidateDto.CountryId.Value
            };

            return candidate;
        }
    }
}
