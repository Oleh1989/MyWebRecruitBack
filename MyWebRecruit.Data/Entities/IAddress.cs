using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public interface IAddress
    {
        string AddressLine { get; set; }
        string AddressCity { get; set; }
        string AddressIndex { get; set; }
        int? CountryId { get; set; }
    }
}
