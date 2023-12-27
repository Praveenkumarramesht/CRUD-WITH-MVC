using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class SchoolDetailss
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Please enter your SchoolName"), MaxLength(50)]
        [StringLength(50, ErrorMessage = "please do not enter values over 50 characters")]
        public string SchoolName { get; set; }

        [Display(Name = "school Address" )]
        [Required(ErrorMessage = "Please enter your school Address"), MaxLength(100)]
        [StringLength(50, ErrorMessage = "please do not enter values over 100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your StartedDate")]
        public DateTime StartedDate { get; set; }

        [Required(ErrorMessage = "Please enter your PhoneNumber"), MaxLength(10)]
        [StringLength(50, ErrorMessage = "please do not enter values over 10 characters")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your Email_id"), MaxLength(20)]
        [StringLength(50, ErrorMessage = "please do not enter values over 20 characters")]
        public string Email_id { get; set; }
    }
}
