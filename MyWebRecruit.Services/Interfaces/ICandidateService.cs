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
        List<CandidateDto> GetCandidateList(int userId);
        CandidateDto GetCandidate(int id);
        void CreateCandidate(CandidateDto candidateDto);
        void UpdateCandidate(CandidateDto candidateDto);
        void DeleteCandidate(int id);
    }
}
