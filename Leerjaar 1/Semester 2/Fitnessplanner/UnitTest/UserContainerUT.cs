using BusinessLogicLayer;
using DatabaseLayer;
using InterfaceLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTest.DummyDAL;

namespace UnitTest
{
    [TestClass]
    public class UserContainerUT
    {
        [TestMethod]
        public void Test_AddOneUser()
        {
            //Arrange
            UserContainer accountContainer = new UserContainer(new UserDummyDAL());

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
            User acc = new User(firstname, lastname, adress, email, password, usertype, substart, subend);
            bool actual = accountContainer.AddOneUser(acc);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteOneUserById()
        {
            //Arrange
            UserContainer accountContainer = new UserContainer(new UserDummyDAL());

            int Id = 2;

            bool expected = true;

            //Act
            bool actual = accountContainer.DeleteOneUserById(Id);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckForPermission()
        {
            //Arrange
            UserContainer accountContainer = new UserContainer(new UserDummyDAL());

            int Id = 2;

            bool expected = true;

            //Act
            bool actual = accountContainer.CheckForPermisson(Id);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_UserExists()
        {
            //Arrange
            UserContainer userContainer = new UserContainer(new UserDummyDAL());

            string email = "Pietje@gmail.com";

            bool expected = true;

            //Act
            bool actual = userContainer.UserExists(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAllUsers()
        {
            //Arrange
            UserContainer accountContainer = new UserContainer(new UserDummyDAL());
            List<User> expected = new List<User>();
            User account = new User();

            account.Id = 1;
            account.Firstname = "Jan";
            account.Lastname = "Jansen";
            account.Adress = "Janlaan";
            account.Email = "Jan@gmail.com";
            account.Password = "Jan123";
            account.Usertype = "User";
            account.SubscriptionStart = "29-04-2022";
            account.SubscriptionEnd = "29-07-2022";

            expected.Add(account);

            //Act
            List<User> actual = accountContainer.GetAllUsers();

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void Test_GetOneUserByEmail()
        {
            //Arrange
            UserContainer accountContainer = new UserContainer(new UserDummyDAL());

            string searchPhrase = "Piet @gmail.com";

            int expId = 2;
            string expFirstname = "Pieter";
            string expLastname = "Post";
            string expAdress = "Pietjelaan";
            string expEmail = "Piet@gmail.com";
            string expSubscriptionStart = "24-04-2022";
            string expSubscriptionEnd = "24-07-2022";
            string expUsertype = "User";

            //Act
            User actual = accountContainer.GetOneUserByEmail(searchPhrase);

            //Assert
            Assert.AreEqual(expId, actual.Id);
            Assert.AreEqual(expFirstname, actual.Firstname);
            Assert.AreEqual(expLastname, actual.Lastname);
            Assert.AreEqual(expAdress, actual.Adress);
            Assert.AreEqual(expEmail, actual.Email);
            Assert.AreEqual(expUsertype, actual.Usertype);
            Assert.AreEqual(expSubscriptionStart, actual.SubscriptionStart);
            Assert.AreEqual(expSubscriptionEnd, actual.SubscriptionEnd);
        }

        [TestMethod]
        public void Test_GetOneUserById()
        {
            //Arrange
            UserContainer accountContainer = new UserContainer(new UserDummyDAL());
            //List<User> expected = new List<User>();
            User account = new User();

            int expId = 2;
            string expFirstname = "Pieter";
            string expLastname = "Post";
            string expAdress = "Pietjelaan";
            string expEmail = "Piet@gmail.com";
            string expPassword = "Piet123";
            string expUsertype = "User";
            string expSubscriptionStart = "24-04-2022";
            string expSubscriptionEnd = "24-07-2022";

            //Act
            User actual = accountContainer.GetOneUserById(expId);

            //Assert
            Assert.AreEqual(expId, actual.Id);
            Assert.AreEqual(expFirstname, actual.Firstname);
            Assert.AreEqual(expLastname, actual.Lastname);
            Assert.AreEqual(expAdress, actual.Adress);
            Assert.AreEqual(expEmail, actual.Email);
            Assert.AreEqual(expPassword, actual.Password);
            Assert.AreEqual(expUsertype, actual.Usertype);
            Assert.AreEqual(expSubscriptionStart, actual.SubscriptionStart);
            Assert.AreEqual(expSubscriptionEnd, actual.SubscriptionEnd);
        }
    }
}
