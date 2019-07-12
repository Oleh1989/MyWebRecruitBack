using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class XClientContact : IIdentified
    {
        // IIdentified interface
        public int Id { get; set; }

        public int ClientId { get; set; }
        public int ContactId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
