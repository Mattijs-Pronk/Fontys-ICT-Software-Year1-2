using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class Login
    {
        static public int userId;
        static public string userfirstname;
        static public string userlastname;
        static public string useremail;
        static public string useradress;
        static public string userusertype;
        static public string usersubstart;
        static public string usersubend;

        public string Email { get; set; }
        public string Password { get; set; }

        ILogin ILogin;

        public Login()
        {

        }

        public Login(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public Login(ILogin dal)
        {
            ILogin = dal;
        }

        public Login(LoginDTO dto)
        {
            this.Email = dto.Email;
            this.Password = dto.Password;

            userId = dto.Id;
            userfirstname = dto.Firstname;
            userlastname = dto.Lastname;
            useremail = dto.Email;
            useradress = dto.Adress;
            userusertype = dto.Usertype;
            usersubstart = dto.SubscriptionStart;
            usersubend = dto.SubscriptionEnd;
        }

        /// <summary>
        /// Methode om ingestuurde gegevens aan de DTO mee te geven.
        /// </summary>
        /// <returns>ingevulde DTO</returns>
        public LoginDTO ToDTO()
        {
            LoginDTO dto = new LoginDTO();
            dto.Email = Email;
            dto.Password = Password;
            return dto;
        }

        /// <summary>
        /// Methode die de database checkt of er een row is met het ingevulde email en wachtwoord.
        /// </summary>
        /// <param name="login">object van user die gechecked moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool LoginUserExists(Login login)
        {
            LoginDTO dto = login.ToDTO();
            return ILogin.LoginUserExists(dto);
        }

        /// <summary>
        /// Methode om gegevens van ingelogde user op tehalen
        /// </summary>
        /// <param name="login">object van user die ingelogd moet worden</param>
        /// <returns>object van ingelogde user</returns>
        public Login LoginUser(Login login)
        {
            LoginDTO dto = login.ToDTO();

            return new Login(ILogin.LoginUser(dto));
        }
    }
}
