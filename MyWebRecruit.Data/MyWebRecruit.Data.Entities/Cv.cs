using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class Cv
    {
        public int CvId { get; set; }
        public string CvLink { get; set; }
        public int CandId { get; set; }

        public bool IsDeleted { get; set; }
        public virtual Candidate Cand { get; set; }
    }
}
