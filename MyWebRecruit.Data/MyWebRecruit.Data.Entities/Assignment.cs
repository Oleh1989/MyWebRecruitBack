using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class Assignment : IIdentified, IDeletable
    {
        // IIdentified interface
        public int Id { get; set; }

        public DateTime StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public decimal Salary { get; set; }
        public int AssigType { get; set; }
        public string JobName { get; set; }
        public string ReasonLeave { get; set; }
        public int CandId { get; set; }
        public int JobId { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual AssigType AssigTypeNavigation { get; set; }
        public virtual Candidate Cand { get; set; }
        public virtual JobGeneral Job { get; set; }
    }
}
