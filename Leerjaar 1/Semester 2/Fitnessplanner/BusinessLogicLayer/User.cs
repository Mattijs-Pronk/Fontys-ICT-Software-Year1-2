using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Usertype { get; set; }
        public string SubscriptionStart { get; set; }
        public string SubscriptionEnd { get; set; }

        IUser IAccount;

        public User()
        {

        }

        public User(IUser dal)
        {
            IAccount = dal;
        }

        public User(UserDTO dto)
        {
            this.Id = dto.Id;
            this.Firstname = dto.Firstname;
            this.Lastname = dto.Lastname;
            this.Adress = dto.Adress;
            this.Email = dto.Email;
            this.Password = dto.Password;
            this.Usertype = dto.Usertype;
            this.SubscriptionStart = dto.SubscriptionStart;
            this.SubscriptionEnd = dto.SubscriptionEnd;
        }

        public User(int userId, string substart, string subend)
        {
            this.Id = userId;
            this.SubscriptionStart = substart;
            this.SubscriptionEnd = subend;
        }

        public User(string firstname, string lastname, string adress, string email, string password, string usertype, string substart, string subend)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Adress = adress;
            this.Email = email;
            this.Password = password;
            this.Usertype = usertype;
            this.SubscriptionStart = substart;
            this.SubscriptionEnd = subend;
        }

        public User(int userId, string firstname, string lastname, string adress, string email, string password, string usertype, string substart, string subend)
        {
            this.Id = userId;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Adress = adress;
            this.Email = email;
            this.Password = password;
            this.Usertype = usertype;
            this.SubscriptionStart = substart;
            this.SubscriptionEnd = subend;
        }

        /// <summary>
        /// Methode om ingestuurde gegevens aan de DTO mee te geven.
        /// </summary>
        /// <returns>ingevulde DTO</returns>
        public UserDTO ToDTO()
        {
            UserDTO dto = new UserDTO();
            dto.Id = Id;
            dto.Firstname = Firstname;
            dto.Lastname = Lastname;
            dto.Adress = Adress;
            dto.Email = Email;
            dto.Password = Password;
            dto.Usertype = Usertype;
            dto.SubscriptionStart = SubscriptionStart;
            dto.SubscriptionEnd = SubscriptionEnd;
            return dto;
        }

        /// <summary>
        /// methode om account met bijbehorende gegevens te bewerken.
        /// </summary>
        /// <param name="user">object van user die aangepast moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool EditOneUserById(User user)
        {
            UserDTO dto = user.ToDTO();
            return IAccount.EditOneUserById(dto);
        }

        /// <summary>
        /// methode om account met subscriptie te bewerken.
        /// </summary>
        /// <param name="user">object van user die aangepast moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool ChangeSubscription(User user)
        {
            UserDTO dto = user.ToDTO();
            return IAccount.ChangeSubscription(dto);
        }
    }
}
