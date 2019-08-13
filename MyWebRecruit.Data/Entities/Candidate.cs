using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.Entities
{
    public partial class Candidate : IIdentified, IDeletable
    {
        public Candidate()
        {
            Assignment = new HashSet<Assignment>();
            Cv = new HashSet<Cv>();
        }

        // IIdentified interface
        public int Id { get; set; }

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
        public int? Age { get; set; }
        public int CreatedBy { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual ICollection<Assignment> Assignment { get; set; }
        public virtual ICollection<Cv> Cv { get; set; }
    }
}
