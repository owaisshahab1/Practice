using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMvcPractice.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string  Name { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile is Required")]
        public string Moblie { get; set; }
    }
}