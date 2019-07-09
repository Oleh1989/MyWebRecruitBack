using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class XJobContact
    {
        public int UniqueId { get; set; }
        public int JobId { get; set; }
        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual JobGeneral Job { get; set; }
    }
}
