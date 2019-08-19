﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Entities
{
    public class AssignmentDto
    {
        public int? Id { get; set; }

        public DateTime StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public decimal Salary { get; set; }
        public int AssigType { get; set; }
        public string JobName { get; set; }
        public string ReasonLeave { get; set; }
        public int CandId { get; set; }
        public string JobAddressLine { get; set; }
        public string JobAddressCity { get; set; }
        public string JobAddressIndex { get; set; }
        public string Country { get; set; }
        public int JobId { get; internal set; }
    }
}