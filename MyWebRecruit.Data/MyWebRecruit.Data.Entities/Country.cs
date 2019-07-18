using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class Country : IIdentified, IDeletable
    {
        public Country()
        {
            CandidateAddress = new HashSet<CandidateAddress>();
            Client = new HashSet<Client>();
            JobGeneral = new HashSet<JobGeneral>();
        }

        //IIdentified interface
        public int Id { get; set; }

        public string CountryName { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual ICollection<CandidateAddress> CandidateAddress { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<JobGeneral> JobGeneral { get; set; }
    }
}
