using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class Client
    {
        public Client()
        {
            XClientContact = new HashSet<XClientContact>();
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? Country { get; set; }
        public string TelNo { get; set; }
        public int CreatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual ICollection<XClientContact> XClientContact { get; set; }
    }
}
