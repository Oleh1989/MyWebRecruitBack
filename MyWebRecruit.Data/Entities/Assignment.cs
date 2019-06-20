using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public class Assignment
    {
        public Guid AssignmentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Salary { get; set; }
        public string JobTitle { get; set; }
        public string ReasonLeave { get; set; }
        public Candidate Candidate { get; set; }
        public Job Job { get; set; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
    }
}
