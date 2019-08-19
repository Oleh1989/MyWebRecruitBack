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
using MyWebRecruit.Data.UnitOfWorks;

namespace MyWebRecruit.Services.Services
{
    public class CandidateService : BaseService, ICandidateService
    {
        public CandidateService(IUnitOfWork uow) : base(uow)
        {

        }

        public List<CandidateDto> GetCandidateList(int userId)
        {
            return _uow.CandidateRepository.GetAll()
                .Where(x => x.CreatedBy == userId)
                .Select(x => x.ToDto()).ToList();
        }

        public CandidateDto GetCandidate(int id)
        {
            return _uow.CandidateRepository.GetById(id).ToDto();
        }

        public void CreateCandidate(CandidateDto candidateDto)
        {
            _uow.CandidateRepository.Add(candidateDto.ToData());
            _uow.Save();
        }

        public void UpdateCandidate(CandidateDto candidateDto)
        {
            _uow.CandidateRepository.Update(candidateDto.ToData());
            _uow.Save();
        }
        public void DeleteCandidate(int id)
        {
            _uow.CandidateRepository.Delete(id);
            _uow.Save();            
        }
    }
}