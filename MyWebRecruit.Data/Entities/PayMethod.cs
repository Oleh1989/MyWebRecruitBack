using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.Entities
{
    public partial class PayMethod : IIdentified, IDeletable
    {
        public PayMethod()
        {
            JobFinancial = new HashSet<JobFinancial>();
        }

        // IIdentified interface
        public int Id { get; set; }

        public string PayMethodDescr { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual ICollection<JobFinancial> JobFinancial { get; set; }
    }
}
