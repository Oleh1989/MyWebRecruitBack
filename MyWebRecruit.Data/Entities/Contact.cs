using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Entities
{
    public class Contact
    {
        public Guid ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public bool? DisturbYN { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }

        public ICollection<Client> Clients { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
