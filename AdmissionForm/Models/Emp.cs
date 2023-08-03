using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdmissionForm.Models
{
    public class Emp
    {
        [DisplayName("Id")]
        [Key]
        [Required(ErrorMessage ="Id is required")]
        public int EmployeId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        public string EmployeName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required")]
        public int EmployeAge { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public string EmployeeGender { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        public string EmployeEmail { get; set; }

        [Required(ErrorMessage = "password is required")]
        public string EmployePassWord { get; set; }
    }
}