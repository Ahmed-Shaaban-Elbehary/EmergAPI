using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmergAPI.Models
{
    public class Operator
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " Required Username. ")]
        [Display(Name = "User Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Required Email. ")]
        public string Email { get; set; }

        [Required(ErrorMessage = " Input Password Please. ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = " Confirme password please. ")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "ID")]
        [Range(1, 1000)]
        public int? IdentificationNumber { get; set; }

        [Display(Name = "Mobile Number")]
        public int? MobilePhone { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [DataType(DataType.Date)]
        public DateTime Hiredate { get; set; }
        
        public decimal Salary { get; set; }

        [UIHint("IsAdmin")]
        [Display(Name = "Is Admin")]
        public bool IsAdmin { get; set; }

        public Gender Gender { get; set; }
    }
}