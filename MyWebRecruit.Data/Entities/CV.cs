using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public class Cv
    {
        public Guid CvId { get; set; }
        public string CvLink { get; set; }
        public Candidate Candidate { get; set; }
    }
}
