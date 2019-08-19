using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebRecruit.ViewModels
{
    class AssignmentViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage ="Start date must be present")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        public DateTime StartDt { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        public DateTime? EndDt { get; set; }

        [Range(0.00, 100000.00)]
        public decimal Salary { get; set; }
        public int AssigType { get; set; }

        [Required(ErrorMessage = "This field shouldn't be empty")]
        [MaxLength(256)]
        public string JobName { get; set; }
        public string ReasonLeave { get; set; }
        public int CandId { get; set; }
        public int JobId { get; set; }

        [MaxLength(256)]
        public string JobAddressLine { get; set; }

        [MaxLength(25)]
        public string JobAddressCity { get; set; }

        [MaxLength(10)]
        public string JobAddressIndex { get; set; }

        [MaxLength(50)]
        public string JobCountry { get; set; }
    }
}
