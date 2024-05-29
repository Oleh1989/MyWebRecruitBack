using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.Entities
{
    public partial class Country : IIdentified, IDeletable
    {
        public Country()
        {
            Candidate = new HashSet<Candidate>();
            Client = new HashSet<Client>();
            JobGeneral = new HashSet<JobGeneral>();
        }

        //IIdentified interface
        public int Id { get; set; }

        public string CountryName { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual ICollection<Candidate> Candidate{ get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<JobGeneral> JobGeneral { get; set; }
    }
}
