using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class AssigType : IIdentified, IDeletable
    {
        public AssigType()
        {
            Assignment = new HashSet<Assignment>();
        }

        // IIDentified interface
        public int Id { get; set; }

        public string AssigTypeDescr { get; set; }

        // IDeletable interface
        public bool IsDeleted { get; set; }

        public virtual ICollection<Assignment> Assignment { get; set; }
    }
}
