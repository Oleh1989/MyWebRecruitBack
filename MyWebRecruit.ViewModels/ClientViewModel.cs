using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebRecruit.ViewModels
{
    public class ClientViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(256)]
        public string Name { get; set; }

        public string WebSite { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(50)]
        public string AddressLine { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(20)]
        public string AddressCity { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(10)]
        public string AddressIndex { get; set; }

        public string Country { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(10)]
        public string TelNo { get; set; }

        public int CreatedBy { get; set; }
    }
}
