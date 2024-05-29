using System;
using System.Collections.Generic;
using System.Text;
using MyWebRecruit.Data.Entities;

namespace MyWebRecruit.Services.Entities
{
    public class ClientDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? CountryId { get; set; }
        public string Country { get; set; }
        public string TelNo { get; set; }
        public int CreatedBy { get; set; }
    }
}
