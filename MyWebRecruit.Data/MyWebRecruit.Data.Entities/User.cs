using System;
using System.Collections.Generic;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public partial class User
    {
        public User()
        {
            Candidate = new HashSet<Candidate>();
            Client = new HashSet<Client>();
            Journal = new HashSet<Journal>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public byte AdminYn { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Candidate> Candidate { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Journal> Journal { get; set; }
    }
}
