using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebRecruit.ViewModels
{
    public class DateAttribute : RangeAttribute
    {
        public DateAttribute() : base(typeof(DateTime), DateTime.Now.AddYears(-70).ToShortDateString(), DateTime.Now.ToShortDateString())
        {

        }
    }
    public class CandidateViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage ="This field shouldn't be empty")]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Field shouldn't be empty")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email is invalid")]
        [MaxLength(256)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Field shouldn't be empty")]
        [MaxLength(15)]
        public string TelNo { get; set; }

        [MaxLength(15)]
        public string AlterTelNo { get; set; }

        public byte? DisturbYn { get; set; }

        [MaxLength(50)]
        public string Facebook { get; set; }

        [MaxLength(50)]
        public string Linkedin { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        [Required(ErrorMessage = "Field shouldn't be empty")]
        [Date(ErrorMessage ="Date must be between 1950 and today")]
        public DateTime? Dob { get; set; }

        [MaxLength(256)]
        public string AddressLine { get; set; }

        [MaxLength(30)]
        public string AddressCity { get; set; }

        [MaxLength(10)]
        public string AddressIndex { get; set; }

        public string Country { get; set; }
    }
}
