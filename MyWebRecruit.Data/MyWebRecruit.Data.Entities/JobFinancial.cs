using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class JobFinancial : IIdentified
    {
        // IIdentified interface
        public int Id { get; set; }

        public string JobCurrency { get; set; }
        public string JobStatus { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public short NoReq { get; set; }
        public string Category { get; set; }
        public decimal? Salary { get; set; }
        public byte? IntershipYn { get; set; }
        public int? PayMethod { get; set; }

        public virtual JobGeneral Job { get; set; }
        public virtual PayMethod PayMethodNavigation { get; set; }
    }
}
