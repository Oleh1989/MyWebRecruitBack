using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class CandidateAddress
    {
        public int CandidateId { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
