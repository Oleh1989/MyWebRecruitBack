using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public class Candidate
    {
        public Guid CandidateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string AlternativeTelephone { get; set; }
        public bool? DisturbYN { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Skype { get; set; }
        public DateTime DOB { get; set; }
        public byte? Age { get; set; }


        public User User { get; set; }

        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressIndex { get; set; }
        public Country Country { get; set; }

        public ICollection<Cv> Cvs { get; set; }
        public ICollection<Assignment> Assignments { get; set; }

    }
}
