using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class AssigType
    {
        public AssigType()
        {
            Assignment = new HashSet<Assignment>();
        }

        public int AssigTypeId { get; set; }
        public string AssigTypeDescr { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Assignment> Assignment { get; set; }
    }
}
