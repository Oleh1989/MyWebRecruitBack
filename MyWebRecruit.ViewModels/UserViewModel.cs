using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebRecruit.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Field shouldn't be empty")]
        [MaxLength(256)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Field shouldn't be empty")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email is invalid")]
        [MaxLength(256)]
        public string UserEmail { get; set; }

        public byte AdminYn { get; set; }
    }
}
