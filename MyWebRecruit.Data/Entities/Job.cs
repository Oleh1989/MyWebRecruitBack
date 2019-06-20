using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public class Job
    {
        public Guid JobID { get; set; }
        public string JobTitle { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public Country Country { get; set; }
        public Currency Currency { get; set; }
        public string JobStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte NumberRequired { get; set; }
        public string Category { get; set; }
        public double? Salary { get; set; }
        public bool Intership { get; set; }
        public PayMethod PayMethod { get; set; }

        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
