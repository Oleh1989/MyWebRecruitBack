using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientWebSite { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public string Telephone { get; set; }        
        public Country Country { get; set; }

        public User CreatedBy { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
