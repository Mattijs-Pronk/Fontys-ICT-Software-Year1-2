using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.DummyDAL
{
    public class LoginDummyDAL : ILogin
    {
        public LoginDTO LoginUser(LoginDTO dto)
        {
            if(dto.Email == "Pietje@gmail.com")
            {
                LoginDTO login = new LoginDTO();
                login.Email = "Pietje@gmail.com";
                login.Password = "Piet123";

                return login;
            }
            else { return null; }
        }

        public bool LoginUserExists(LoginDTO dto)
        {
            try
            {
                if (dto.Email == "Peter@gmail.com") { return true; }
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
