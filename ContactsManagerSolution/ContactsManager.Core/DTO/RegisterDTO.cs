using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Core.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage ="Name cannot be empty")]
        [EmailAddress(ErrorMessage ="Email must be in the proper format")]
        [DataType(DataType.EmailAddress)]  
        public string PersonName { get; set; }


        [Required(ErrorMessage = "Phone cannot be empty")]
        [RegularExpression("^[0-9]*$" , ErrorMessage ="Phone must contain Only Numbers")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email cannot be empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password cannot be empty")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }


    }
}
