using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.Entities
{
    public partial class Contact : IIdentified, IDeletable
    {
        public Contact()
        {
            XClientContact = new HashSet<XClientContact>();
            XJobContact = new HashSet<XJobContact>();
        }

        // IIdentified interface
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public byte? DisturbYn { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }

        // added manualy to service working properly with id
        public int ClientId { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual ICollection<XClientContact> XClientContact { get; set; }
        public virtual ICollection<XJobContact> XJobContact { get; set; }
    }
}
