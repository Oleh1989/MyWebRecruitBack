using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Entities
{
    public class ContactDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public byte DisturbYn { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }

        public int ClientId { get; set; }
    }
}
