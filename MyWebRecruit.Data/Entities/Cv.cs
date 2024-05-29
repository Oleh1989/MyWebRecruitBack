using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.Entities
{
    public partial class Cv : IIdentified, IDeletable
    {
        // IIdentified interface
        public int Id { get; set; }

        public string CvLink { get; set; }
        public int CandId { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }
        public virtual Candidate Cand { get; set; }
    }
}
