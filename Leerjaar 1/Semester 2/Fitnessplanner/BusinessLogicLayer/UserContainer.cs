using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class UserContainer
    {
        IUserContainer IAccountContainer;

        public UserContainer()
        {
        }

        public UserContainer(IUserContainer dal)
        {
            IAccountContainer = dal;
        }

        /// <summary>
        /// Methode om een account met bijbehorende gegevens aan te maken.
        /// </summary>
        /// <param name="user">Object van user die toegevoegd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneUser(User user)
        {
            UserDTO dto = user.ToDTO();
            return IAccountContainer.AddOneUser(dto);
        }

        /// <summary>
        /// methode om account met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Userid van user die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneUserById(int id)
        {
            return IAccountContainer.DeleteOneUserById(id);
        }

        /// <summary>
        /// methode om te checken of email al bestaat in de database.
        /// </summary>
        /// <param name="email">email van user om te checken of deze al bestaat</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool UserExists(string email)
        {
            return IAccountContainer.UserExists(email);
        }

        /// <summary>
        /// methode om uit te lezen of het account een admin of user is.
        /// </summary>
        /// <param name="id">Userid van user die gechecked moet worden op usertype</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool CheckForPermisson(int id)
        {
            return IAccountContainer.CheckForPermission(id);
        }

        /// <summary>
        /// list aanmaken die alle accounts met bijbehorende gegevens ophaalt.
        /// </summary>
        /// <returns>list van alle users</returns>
        public List<User> GetAllUsers()
        {
            //list aanmaken en vullen.
            List<User> allaccounts = new List<User>();
            List<UserDTO> list = IAccountContainer.GetAllUsers();
            foreach (UserDTO account in list)
            {
                User newaccount = new User(account);
                allaccounts.Add(newaccount);
            }
            return allaccounts;
        }

        /// <summary>
        /// object aanmaken die een enkel account met bijbehorende gegevens ophaalt door de email in te vullen.
        /// </summary>
        /// <param name="id">Userid van user die opgehaald moet worden</param>
        /// <returns>user</returns>
        public User GetOneUserById(int id)
        {
            return new User(IAccountContainer.GetOneUserById(id));
        }

        /// <summary>
        /// Methode die enkele user ophaald door searchphrase te gebruiken.
        /// </summary>
        /// <param name="SearchPhrase">email van user die opgehaald moet worden</param>
        /// <returns>user</returns>
        public User GetOneUserByEmail(string SearchPhrase)
        {
            return new User(IAccountContainer.GetOneUserByEmail(SearchPhrase));
        }
    }
}
