using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Notaion.Models
{
    public class Employee
    {
        [DisplayName("Id")]
        [Required(ErrorMessage ="id is required")]
        public int EmployeId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="lengh between 5 to 20")]
        public string EmployeName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required")]
        [Range(20,60,ErrorMessage ="Enter age 20 btn 60")]
        public int  EmployeAge { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public string EmployeeGender { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[\w.-]+@[a-zA-Z\d.-]+\.[a-zA-Z]{2,}$",ErrorMessage ="Invalid Email")]
        public string EmployeEmail { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage ="Password is requird")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage ="make strong password")]
        [DataType(DataType.Password)]
        public string EmployePassWord { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Password is requird")]
        [Compare("EmployePassWord",ErrorMessage ="not identical with password")]
        public string EmployeComfirmPassword { get; set; }


        [DisplayName("Emporganization")]
        [ReadOnly(true)]
        public string Emporganization { get; set; }







    }
}