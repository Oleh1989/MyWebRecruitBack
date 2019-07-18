using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class Client : IIdentified, IDeletable, IAddress
    {
        public Client()
        {
            XClientContact = new HashSet<XClientContact>();
        }

        // IIdenified interface
        public int Id { get; set; }

        public string Name { get; set; }
        public string WebSite { get; set; }

        // IAddress interface
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? CountryId { get; set; }

        public string TelNo { get; set; }
        public int CreatedBy { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual ICollection<XClientContact> XClientContact { get; set; }
    }
}
