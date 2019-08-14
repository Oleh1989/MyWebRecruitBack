using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Services.Entities;

namespace MyWebRecruit.Services.Interfaces
{
    public interface IAssignmentService
    {
        IQueryable<AssignmentDto> GetAssignmentList();
        void CreateAssignment(int assignmentId, CandidateDto candidate, JobDto job);
        void UpdateAssignment(AssignmentDto assignment);
        void DeleteAssignment(AssignmentDto assignment);
    }
}
