using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace UnitTest.DummyDAL
{
    class UserDummyDAL : IUser, IUserContainer
    {
        public List<UserDTO> list = new List<UserDTO>();

        public bool AddOneUser(UserDTO dto)
        {
            try
            {
                if (dto.Firstname == "Jan" && dto.Lastname == "Jansen" && dto.Adress == "Janlaan" && dto.Email == "Jan@gmail.com" && dto.Password == "Jan123" && dto.Usertype == "User" && dto.SubscriptionStart == "29-04-2022" && dto.SubscriptionEnd == "29-07-2022") { 
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool ChangeSubscription(UserDTO dto)
        {
            try
            {
                if(dto.Id == 2 && dto.SubscriptionStart == "29-04-2022" && dto.SubscriptionEnd == "29-07-2022") {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool CheckForPermission(int id)
        {
            try
            {
                if(id == 2) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool DeleteOneUserById(int id)
        {
            try
            {
                if(id == 2) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool EditOneUserById(UserDTO dto)
        {
            try
            {
                if(dto.Id == 2 && dto.Firstname == "Jan"  && dto.Lastname == "Jansen" && dto.Adress == "Janlaan"  && dto.Email == "Jan@gmail.com" && dto.Password == "Jan123" && dto.Usertype == "User" && dto.SubscriptionStart == "29-04-2022"  && dto.SubscriptionEnd == "29-07-2022") {
                    return true;
                }
                else { return false; }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public List<UserDTO> GetAllUsers()
        {
            UserDTO dto = new UserDTO();
            dto.Id = 2;
            dto.Firstname = "Pieter";
            dto.Lastname = "Post";
            dto.Adress = "Pietjelaan";
            dto.Email = "Piet@gmail.com";
            dto.SubscriptionStart = "24-04-2022";
            dto.SubscriptionEnd = "24-07-2022";
            dto.Usertype = "User";

            list.Add(dto);
            return list;
        }

        public UserDTO GetOneUserByEmail(string SearchPhrase)
        {
            try
            {
                if(SearchPhrase == "Piet @gmail.com")
                {
                    UserDTO dto = new UserDTO();
                    dto.Id = 2;
                    dto.Firstname = "Pieter";
                    dto.Lastname = "Post";
                    dto.Adress = "Pietjelaan";
                    dto.Email = "Piet@gmail.com";
                    dto.SubscriptionStart = "24-04-2022";
                    dto.SubscriptionEnd = "24-07-2022";
                    dto.Usertype = "User";

                    return dto;
                }
                else { return null; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public UserDTO GetOneUserById(int id)
        {
            if(id == 2)
            {
                UserDTO dto = new UserDTO();
                dto.Id = 2;
                dto.Firstname = "Pieter";
                dto.Lastname = "Post";
                dto.Adress = "Pietjelaan";
                dto.Email = "Piet@gmail.com";
                dto.Password = "Piet123";
                dto.Usertype = "User";
                dto.SubscriptionStart = "24-04-2022";
                dto.SubscriptionEnd = "24-07-2022";

                return dto;
            }
            else { return null; }
        }

        public bool UserExists(string email)
        {
            try
            {
                if(email == "Pietje@gmail.com") { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
