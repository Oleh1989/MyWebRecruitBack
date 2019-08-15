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
        List<AssignmentDto> GetAssignmentList();
        void CreateAssignment(AssignmentDto assignmentDto);
        void UpdateAssignment(AssignmentDto assignmentDto);
        void DeleteAssignment(int id);
    }
}
