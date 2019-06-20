using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<Client> Clients { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Journal> Journals { get; set; }
    }
}
