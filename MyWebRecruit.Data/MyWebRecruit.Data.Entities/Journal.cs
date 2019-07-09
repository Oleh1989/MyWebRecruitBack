using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class Journal
    {
        public int JournalId { get; set; }
        public int EntityId { get; set; }
        public string Description { get; set; }
        public DateTime DtLogged { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User Entity { get; set; }
    }
}
