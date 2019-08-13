using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Domain.Entities;

namespace MyWebRecruit.Domain.Services
{
    public interface ICandidateService
    {
        IQueryable<Candidate> GetCandidateList(User user);
        void CreateCandidate(int userId);
        void UpdateCandidate(Candidate candidate, int userId);
        void DeleteCandidate(Candidate candidate);
    }
}
