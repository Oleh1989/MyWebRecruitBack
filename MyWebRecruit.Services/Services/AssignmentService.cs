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

        public void UpdateAssignment(AssignmentDto assignment)
        {
            DateTime satrtDtDummy = DateTime.Now, endDtDummy = DateTime.Now;
            decimal salaryDummy = 0;
            int assigTypeDummy = 0;
            string jobNameDummy = string.Empty;
            string reasonLeaveDummy = string.Empty;

            using (var context = new MyWebRecruitDataBaseContext())
            {
                var assignmentToUpdate = context.Assignment.FirstOrDefault(x => x.Id == assignment.Id);
                if (assignmentToUpdate != null)
                {
                    assignmentToUpdate.StartDt = satrtDtDummy;
                    assignmentToUpdate.EndDt = endDtDummy;
                    assignmentToUpdate.Salary = salaryDummy;
                    assignmentToUpdate.AssigType = assigTypeDummy;
                    assignmentToUpdate.JobName = jobNameDummy;
                    assignmentToUpdate.ReasonLeave = reasonLeaveDummy;

                    context.Assignment.Update(assignmentToUpdate);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteAssignment(AssignmentDto assignment)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var assignmentToDelete = context.Assignment.FirstOrDefault(x => x.Id == assignment.Id);
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
