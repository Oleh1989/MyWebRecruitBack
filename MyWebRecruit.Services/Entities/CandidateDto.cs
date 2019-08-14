﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Entities
{
    public class CandidateDto
    {
        public int? Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public string AlterTelNo { get; set; }
        public byte? DisturbYn { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Skype { get; set; }
        public DateTime? Dob { get; set; }
        public int CreatedBy { get; set; }

        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public int? CountryId { get; set; }
        public string Country { get; set; }
    }
}
