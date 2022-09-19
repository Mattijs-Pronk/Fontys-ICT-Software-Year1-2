using BusinessLogicLayer;
using DatabaseLayer;
using InterfaceLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest.DummyDAL;

namespace UnitTest
{
    [TestClass]
    public class UserUT
    {
        [TestMethod]
        public void Test_ToDTO()
        {
            //Arrange
            User account = new User();
            UserDTO dto = new UserDTO();

            account.Id = 2;
            account.Firstname = "User1";
            account.Lastname = "User1";
            account.Adress = "User1";
            account.Email = "User1";
            account.Password = "User123";
            account.Usertype = "User";



            int expectedId = 2;
            string expectedFirstname = "User1";
            string expectedLastname = "User1";
            string expectedAdress = "User1";
            string expectedEmail = "User1";
            string expectedPassword = "User123";
            string expectedUsertype = "User";

            //Act
            dto = account.ToDTO();

            //Assert
            Assert.AreEqual(expectedId, dto.Id);
            Assert.AreEqual(expectedFirstname, dto.Firstname);
            Assert.AreEqual(expectedLastname, dto.Lastname);
            Assert.AreEqual(expectedAdress, dto.Adress);
            Assert.AreEqual(expectedEmail, dto.Email);
            Assert.AreEqual(expectedPassword, dto.Password);
            Assert.AreEqual(expectedUsertype, dto.Usertype);
        }

        [TestMethod]
        public void Test_EditOneUserById()
        {
            //Arrange
            User account = new User(new UserDummyDAL());

            int Id = 2;
            string firstname = "Jan";
            string lastname = "Jansen";
            string adress = "Janlaan";
            string email = "Jan@gmail.com";
            string password = "Jan123";
            string substart = "29-04-2022";
            string subend = "29-07-2022";
            string usertype = "User";

            bool expected = true;

            //Act
            User acc = new User(Id, firstname, lastname, adress, email, password, usertype, substart, subend);
            bool actual = account.EditOneUserById(acc);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ChangeSubscription()
        {
            //Arrange
            User account = new User(new UserDummyDAL());

            int Id = 2;
            string substart = "29-04-2022";
            string subend = "29-07-2022";

            bool expected = true;

            //Act
            User acc = new User(Id, substart, subend);
            bool actual = account.ChangeSubscription(acc);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
