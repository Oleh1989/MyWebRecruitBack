using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.Entities
{
    public partial class JobGeneral : IIdentified, IDeletable, IAddress
    {
        public JobGeneral()
        {
            Assignment = new HashSet<Assignment>();
            XJobContact = new HashSet<XJobContact>();
        }

        // IIdeletable interface
        public int Id { get; set; }

        public string Name { get; set; }

        // IAddress interface
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? CountryId { get; set; }
        public string Country { get; set; }

        // IDeletable interface
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

        public virtual Country CountryNavigation { get; set; }
        public virtual ICollection<Assignment> Assignment { get; set; }
        public virtual ICollection<XJobContact> XJobContact { get; set; }
        public virtual PayMethod PayMethodNavigation { get; set; }
    }
}
