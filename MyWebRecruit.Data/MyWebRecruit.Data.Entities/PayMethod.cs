using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class PayMethod
    {
        public PayMethod()
        {
            JobFinancial = new HashSet<JobFinancial>();
        }

        public int PayMethodId { get; set; }
        public string PayMethodDescr { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<JobFinancial> JobFinancial { get; set; }
    }
}
