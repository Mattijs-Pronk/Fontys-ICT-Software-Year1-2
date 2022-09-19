using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Fill in email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Fill in password")]
        public string Password { get; set; }
    }
}
