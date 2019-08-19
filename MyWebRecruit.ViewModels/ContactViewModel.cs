using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebRecruit.ViewModels
{
    public class ContactViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(20)]
        public string TelNo { get; set; }

        [Required(ErrorMessage = "Field shouldn't be empty")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email is invalid")]
        [MaxLength(256)]
        public string Email { get; set; }


        public byte? DisturbYn { get; set; }

        [MaxLength(256)]
        public string Department { get; set; }

        [MaxLength(256)]
        public string JobTitle { get; set; }

        [MaxLength(256)]
        public string ClientName { get; set; }

        [MaxLength(256)]
        public string ClientAddressLine { get; set; }

        [MaxLength(50)]
        public string ClientAddressCity { get; set; }

        [MaxLength(10)]
        public string ClientAddressIndex { get; set; }

        [MaxLength(50)]
        public string ClientCountry { get; set; }


        public string ClientTelNo { get; set; }
    }
}
