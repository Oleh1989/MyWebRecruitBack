using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
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
        public int? Country { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual JobFinancial JobFinancial { get; set; }
        public virtual ICollection<Assignment> Assignment { get; set; }
        public virtual ICollection<XJobContact> XJobContact { get; set; }
    }
}
