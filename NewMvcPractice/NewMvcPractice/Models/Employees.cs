using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMvcPractice.Models
{
    public class Employees
    {
        [Display(Name="Id: ")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Display(Name = "Name: ")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile is Required")]
        [Display(Name = "Mobile: ")]
        public string Mobile { get; set; }
    }
}