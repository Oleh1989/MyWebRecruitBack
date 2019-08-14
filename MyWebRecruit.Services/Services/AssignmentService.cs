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
    public class AssignmentService : BaseService, IAssignmentService
    {
        public AssignmentService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }

        public IQueryable<AssignmentDto> GetAssignmentList()
        {
            IQueryable<AssignmentDto> assignments;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                assignments = context.Assignment
                    .Cast<AssignmentDto>()
                    .Where(x => !x.IsDeleted)
                    .OrderBy(x => x.JobName);
            }

            return assignments;
        }

        public void CreateAssignment(AssignmentDto assignmentDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                context.Assignment.Add(assignmentDto.ToData());
                context.SaveChanges();
            }
        }

        public void UpdateAssignment(AssignmentDto assignmentDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var assignmentToUpdate = context.Assignment.FirstOrDefault(x => x.Id == assignmentDto.Id);
                if (assignmentToUpdate != null)
                {
                    context.Assignment.Update(assignmentDto.ToData());
                    context.SaveChanges();
                }
            }
        }

        public void DeleteAssignment(AssignmentDto assignmentDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var assignmentToDelete = context.Assignment.FirstOrDefault(x => x.Id == assignmentDto.Id);
                if (assignmentToDelete != null)
                {
                    assignmentToDelete.IsDeleted = true;

                    context.Assignment.Update(assignmentToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
