using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Domain.Services;
using MyWebRecruit.Data.MyWebRecruit.Data.Entities;

namespace MyWebRecruit.Services
{
    public class CandidateService : BaseService, ICandidateService
    {
        public CandidateService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }

        public void GetCandidateList()
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                IQueryable<Candidate> candidates = context.Candidate
                    .Where(x => x.IsDeleted == false)
                    .OrderBy(x => x.LastName);
            }
        }

        public void CreateCandidate(int userId)
        {
            string firstNameDummy = string.Empty, lastNameDummy = string.Empty, middleNameDummy = string.Empty;
            string emailDummy = string.Empty;
            string telephoneDummy = string.Empty, alterTelephoneDummy = string.Empty;
            byte disturbYN = 0;
            string facebookDummy = string.Empty, linkedinDummy = string.Empty, skypeDummy = string.Empty;
            DateTime dobDummy = DateTime.Now;
            int ageDummy = DateTime.Now.Year - dobDummy.Year;

            string AddressLineDummy = string.Empty, addressCityDummy = string.Empty, addressIndex = string.Empty;

            string exceptionMessage = null;
            bool isEmailValid = false;

            using (var context = new MyWebRecruitDataBaseContext())
            {
                exceptionMessage = Logic.NullOrEmptyField(firstNameDummy, lastNameDummy, emailDummy,
                    telephoneDummy, dobDummy.ToString(), ageDummy.ToString());
                isEmailValid = Logic.EmailValidation(emailDummy);
                if (exceptionMessage == null && isEmailValid)
                {
                    var newCandidate = new Candidate
                    {
                        FirstName = firstNameDummy,
                        LastName = lastNameDummy,
                        MiddleName = middleNameDummy,
                        Email = emailDummy,
                        TelNo = telephoneDummy,
                        AlterTelNo = alterTelephoneDummy,
                        DisturbYn = disturbYN,
                        Facebook = facebookDummy,
                        Linkedin = linkedinDummy,
                        Skype = skypeDummy,
                        Dob = dobDummy,
                        Age = ageDummy,
                        CreatedBy = userId
                    };
                    var newCandAddress = new CandidateAddress
                    {
                        Id = newCandidate.Id,
                        AddressLine = AddressLineDummy,
                        AddressCity = addressCityDummy,
                        AddressIndex = addressIndex
                    };
                    context.Candidate.Add(newCandidate);
                    context.CandidateAddress.Add(newCandAddress);
                    context.SaveChanges();
                }
            }
        }

        public void UpdateCandidate(Domain.Entities.Candidate candidate, int userId)
        {
            string firstNameDummy = string.Empty, lastNameDummy = string.Empty, middleNameDummy = string.Empty;
            string emailDummy = string.Empty;
            string telephoneDummy = string.Empty, alterTelephoneDummy = string.Empty;
            byte disturbYN = 0;
            string facebookDummy = string.Empty, linkedinDummy = string.Empty, skypeDummy = string.Empty;
            DateTime dobDummy = DateTime.Now;
            int ageDummy = DateTime.Now.Year - dobDummy.Year;

            string AddressLineDummy = string.Empty, addressCityDummy = string.Empty, addressIndex = string.Empty;

            string exceptionMessage = null;
            bool isEmailValid = false;

            using (var context = new MyWebRecruitDataBaseContext())
            {
                var candidateToUpdate = context.Candidate.FirstOrDefault(c => c.Id == candidate.Id);
                if (candidate != null)
                {
                    exceptionMessage = Logic.NullOrEmptyField(firstNameDummy, lastNameDummy, emailDummy,
                   telephoneDummy, dobDummy.ToString(), ageDummy.ToString());
                    isEmailValid = Logic.EmailValidation(emailDummy);
                    if (exceptionMessage == null && isEmailValid)
                    {
                        var newCandidate = new Candidate
                        {
                            FirstName = firstNameDummy,
                            LastName = lastNameDummy,
                            MiddleName = middleNameDummy,
                            Email = emailDummy,
                            TelNo = telephoneDummy,
                            AlterTelNo = alterTelephoneDummy,
                            DisturbYn = disturbYN,
                            Facebook = facebookDummy,
                            Linkedin = linkedinDummy,
                            Skype = skypeDummy,
                            Dob = dobDummy,
                            Age = ageDummy,
                            CreatedBy = userId
                        };
                        var newCandAddress = new CandidateAddress
                        {
                            Id = newCandidate.Id,
                            AddressLine = AddressLineDummy,
                            AddressCity = addressCityDummy,
                            AddressIndex = addressIndex
                        };
                        context.Candidate.Update(newCandidate);
                        context.CandidateAddress.Update(newCandAddress);
                        context.SaveChanges();
                    }
                }               
            }            
        }
        public void DeleteCandidate(Domain.Entities.Candidate candidate)
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
