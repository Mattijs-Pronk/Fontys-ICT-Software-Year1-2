using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        public string Usertype { get; set; }

        public string SubscriptionStart { get; set; }

        public string SubscriptionEnd { get; set; }

        public UserViewModel()
        {

        }

        public UserViewModel(int id, string firstname, string lastname, string adress, string email, string password, string usertype, string substart, string subend)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Adress = adress;
            this.Email = email;
            this.Password = password;
            this.Usertype = usertype;
            this.SubscriptionStart = substart;
            this.SubscriptionEnd = subend;
        }
    }
}
