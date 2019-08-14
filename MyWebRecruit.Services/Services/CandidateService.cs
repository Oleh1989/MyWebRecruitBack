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

        public void UpdateCandidate(CandidateDto candidateDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var candidateToUpdate = context.Candidate.FirstOrDefault(c => c.Id == candidateDto.Id);
                if (candidateToUpdate != null)
                {
                    context.Candidate.Update(candidateDto.ToData());
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
