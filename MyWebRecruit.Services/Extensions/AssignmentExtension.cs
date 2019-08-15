using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Extensions
{
    public static class AssignmentExtension
    {
        public static AssignmentDto ToDto(this Assignment assignment)
        {
            if (assignment == null)
                return null;

            var assignmentDto = new AssignmentDto
            {
                AssigType = assignment.AssigType,
                CandId = assignment.CandId,
                EndDt = assignment.EndDt,
                Id = assignment.Id,
                JobId = assignment.JobId,
                JobName = assignment.JobName,
                ReasonLeave = assignment.ReasonLeave,
                Salary = assignment.Salary,
                StartDt = assignment.StartDt
            };

            return assignmentDto;
        }

        public static Assignment ToData(this AssignmentDto assignmentDto)
        {
            if(assignmentDto == null)
                return null;

            var assignment = new Assignment
            {
                AssigType = assignmentDto.AssigType,
                CandId = assignmentDto.CandId,
                EndDt = assignmentDto.EndDt,
                Id = assignmentDto.Id.Value,
                JobId = assignmentDto.JobId,
                JobName = assignmentDto.JobName,
                ReasonLeave = assignmentDto.ReasonLeave,
                Salary = assignmentDto.Salary,
                StartDt = assignmentDto.StartDt
            };

            return assignment;
        }
    }
}
