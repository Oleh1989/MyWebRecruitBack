using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Services.Entities;

namespace MyWebRecruit.Services.Interfaces
{
    public interface ICandidateService
    {
        IQueryable<CandidateDto> GetCandidateList(UserDto user);
        void CreateCandidate(int userId);
        void UpdateCandidate(CandidateDto candidate, int userId);
        void DeleteCandidate(CandidateDto candidate);
    }
}
