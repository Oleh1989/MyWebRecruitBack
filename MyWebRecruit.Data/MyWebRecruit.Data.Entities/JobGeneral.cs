using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class JobGeneral
    {
        public JobGeneral()
        {
            Assignment = new HashSet<Assignment>();
            XJobContact = new HashSet<XJobContact>();
        }

        public int JobId { get; set; }
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? Country { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual JobFinancial JobFinancial { get; set; }
        public virtual ICollection<Assignment> Assignment { get; set; }
        public virtual ICollection<XJobContact> XJobContact { get; set; }
    }
}
