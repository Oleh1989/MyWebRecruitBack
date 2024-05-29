using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebRecruit.ViewModels
{
    public class JobViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(256)]
        public string AddressLine { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(50)]
        public string AddressCity { get; set; }

        public string AddressIndex { get; set; }

        public string Country { get; set; }

        [Required(ErrorMessage = "Enter a code of a currency")]
        [MaxLength(5)]
        public string JobCurrency { get; set; }

        public string JobStatus { get; set; }

        [Required(ErrorMessage ="Start date must be present")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        public DateTime? StartDt { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        public DateTime? EndDt { get; set; }

        public short NoReq { get; set; }

        public string Category { get; set; }

        [Range(0.00, 100000.00)]
        public decimal? Salary { get; set; }
        public byte? IntershipYn { get; set; }
        public int? PayMethod { get; set; }

        [Required(ErrorMessage ="Enter a client name")]
        public string ClientName { get; set; }

        public int ContactId { get; set; }
    }
}
