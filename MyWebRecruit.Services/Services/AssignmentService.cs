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
    public class AssignmentService : BaseService, IAssignmentService
    {
        public AssignmentService(IUnitOfWork uow) : base(uow)
        {

        }

        public List<AssignmentDto> GetAssignmentList()
        {
            return _uow.AssignmentRepository.GetAll().Select(x => x.ToDto()).ToList();
        }

        public void CreateAssignment(AssignmentDto assignmentDto)
        {
            _uow.AssignmentRepository.Add(assignmentDto.ToData());
            _uow.Save();
        }

        public void UpdateAssignment(AssignmentDto assignmentDto)
        {
            _uow.AssignmentRepository.Update(assignmentDto.ToData());
            _uow.Save();
        }

        public void DeleteAssignment(int id)
        {
            _uow.AssignmentRepository.Delete(id);
            _uow.Save();
        }
    }
}
