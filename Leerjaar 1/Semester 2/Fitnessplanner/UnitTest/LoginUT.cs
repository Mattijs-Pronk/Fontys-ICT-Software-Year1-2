using BusinessLogicLayer;
using InterfaceLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.DummyDAL;

namespace UnitTest
{
    [TestClass]
    public class LoginUT
    {
        [TestMethod]
        public void Test_ToDTO()
        {
            //Arrange
            Login login = new Login();
            LoginDTO dto = new LoginDTO();

            login.Email = "Peter@gmail.com";
            login.Password = "Peter123";

            string expectedEmail = "Peter@gmail.com";
            string expectedPassword = "Peter123";

            //Act
            dto = login.ToDTO();

            //Assert
            Assert.AreEqual(expectedEmail, dto.Email);
            Assert.AreEqual(expectedPassword, dto.Password);
        }

        [TestMethod]
        public void Test_LoginUserExists()
        {
            //Arrange
            Login login = new Login(new LoginDummyDAL());

            string email = "Peter@gmail.com";
            string password = "Peter123";

            bool expected = true;

            //Act
            Login log = new Login(email, password);
            bool actual = login.LoginUserExists(log);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_LoginUser()
        {
            //Arrange
            Login login = new Login(new LoginDummyDAL());
            List<Login> expected = new List<Login>();
            

            string expemail = "Pietje@gmail.com";
            string exppassword = "Piet123";
            

            //Act
            Login log = new Login(expemail, exppassword);
            Login actual = login.LoginUser(log);

            //Assert
            Assert.AreEqual(expemail, actual.Email);
            Assert.AreEqual(exppassword, actual.Password);
        }
    }
}
