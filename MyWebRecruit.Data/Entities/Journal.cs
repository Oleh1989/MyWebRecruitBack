using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public class Journal
    {
        public Guid JournalId { get; set; }
        public string Descripton { get; set; }
        public DateTime TimeLogged { get; set; }
        public User User { get; set; }
    }
}
