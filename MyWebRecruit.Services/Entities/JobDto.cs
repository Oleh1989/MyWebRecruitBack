using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Entities
{
    public class JobDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? CountryId { get; set; }

        public bool IsDeleted { get; set; }

        public string JobCurrency { get; set; }
        public string JobStatus { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public short NoReq { get; set; }
        public string Category { get; set; }
        public decimal? Salary { get; set; }
        public byte? IntershipYn { get; set; }
        public int? PayMethod { get; set; }

        public int ContactId { get; set; }
    }
}
