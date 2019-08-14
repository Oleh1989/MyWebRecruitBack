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
        void CreateCandidate(CandidateDto candidateDto);
        void UpdateCandidate(CandidateDto candidateDto);
        void DeleteCandidate(CandidateDto candidate);
    }
}
