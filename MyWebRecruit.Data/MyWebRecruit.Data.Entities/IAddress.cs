using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    interface IAddress
    {
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? CountryId { get; set; }
    }
}
