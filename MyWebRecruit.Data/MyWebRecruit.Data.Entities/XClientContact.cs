using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class XClientContact
    {
        public int UniqueId { get; set; }
        public int ClientId { get; set; }
        public int ContactId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
