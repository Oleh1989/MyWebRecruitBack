using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.Services.Extensions;

namespace MyWebRecruit.Services.Services
{
    public class CandidateService : BaseService, ICandidateService
    {
        public CandidateService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }

        public IQueryable<CandidateDto> GetCandidateList(UserDto user)
        {
            IQueryable<CandidateDto> candidates;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                candidates = context.Candidate.Cast<CandidateDto>()
                    .Where(x => !x.IsDeleted && x.CreatedBy == user.Id)
                    .OrderBy(x => x.LastName);
            }

            return candidates;
        }

        public void CreateCandidate(CandidateDto candidateDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                context.Candidate.Add(candidateDto.ToData());
                context.SaveChanges();
            }
        }

        public void UpdateCandidate(CandidateDto candidate, int userId)
        {
            string firstNameDummy = string.Empty, lastNameDummy = string.Empty, middleNameDummy = string.Empty;
            string emailDummy = string.Empty;
            string telephoneDummy = string.Empty, alterTelephoneDummy = string.Empty;
            byte disturbYN = 0;
            string facebookDummy = string.Empty, linkedinDummy = string.Empty, skypeDummy = string.Empty;
            DateTime dobDummy = DateTime.Now;
            int ageDummy = DateTime.Now.Year - dobDummy.Year;

            string AddressLineDummy = string.Empty, addressCityDummy = string.Empty, addressIndex = string.Empty;

            using (var context = new MyWebRecruitDataBaseContext())
            {
                var candidateToUpdate = context.Candidate.FirstOrDefault(c => c.Id == candidate.Id);
                if (candidateToUpdate != null)
                {
                    candidateToUpdate.FirstName = firstNameDummy;
                    candidateToUpdate.LastName = lastNameDummy;
                    candidateToUpdate.MiddleName = middleNameDummy;
                    candidateToUpdate.Email = emailDummy;
                    candidateToUpdate.TelNo = telephoneDummy;
                    candidateToUpdate.AlterTelNo = alterTelephoneDummy;
                    candidateToUpdate.DisturbYn = disturbYN;
                    candidateToUpdate.Facebook = facebookDummy;
                    candidateToUpdate.Linkedin = linkedinDummy;
                    candidateToUpdate.Skype = skypeDummy;
                    candidateToUpdate.Dob = dobDummy;
                    candidateToUpdate.Age = ageDummy;
                    candidateToUpdate.AddressLine = AddressLineDummy;
                    candidateToUpdate.AddressCity = addressCityDummy;
                    candidateToUpdate.AddressIndex = addressIndex;

                    context.Candidate.Update(candidateToUpdate);
                    context.SaveChanges();

                }
            }
        }
        public void DeleteCandidate(CandidateDto candidate)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var candidateToDelete = context.Candidate.FirstOrDefault(c => c.Id == candidate.Id);
                if (candidateToDelete != null)
                {
                    candidateToDelete.IsDeleted = true;

                    context.Candidate.Update(candidateToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
