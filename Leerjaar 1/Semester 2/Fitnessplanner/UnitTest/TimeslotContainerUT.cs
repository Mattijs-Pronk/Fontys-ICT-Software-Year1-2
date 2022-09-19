using BusinessLogicLayer;
using DatabaseLayer;
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
    public class TimeslotContainerUT
    {
        [TestMethod]
        public void Test_AddOneTimeslot()
        {
            //Arrange
            TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDummyDAL());

            string Day = "30-04-2022";
            string Timeslot = "09:00";
            int Maxres = 60;

            bool expected = true;

            //Act
            Timeslot time = new Timeslot(Day, Timeslot, Maxres);
            bool actual = timeslotContainer.AddOneTimeslot(time);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteOneTimeslotById()
        {
            //Arrange
            TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDummyDAL());

            int Id = 2;

            bool expected = true;

            //Act
            bool actual = timeslotContainer.DeleteOneTimeslotById(Id);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteOneTimeslotByDay()
        {
            //Arrange
            TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDummyDAL());

            string Day = "30-04-2022";

            bool expected = true;

            //Act
            bool actual = timeslotContainer.DeleteOneTimeslotByDay(Day);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAllTimeslots()
        {
            //Arrange
            TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDummyDAL());
            List<Timeslot> expected = new List<Timeslot>();
            Timeslot timeslot = new Timeslot();

            timeslot.TimeslotID = 1;
            timeslot.Day = "30-04-2022";
            timeslot.Timeslots = "09:00";
            timeslot.Currentreservations = 2;
            timeslot.Maxreservations = 60;

            expected.Add(timeslot);

            //Act
            List<Timeslot> actual = timeslotContainer.GetAllTimeslots();

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void Test_UserGetOneTimeslotByDay()
        {
            //Arrange
            TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDummyDAL());
            List<Timeslot> expected = new List<Timeslot>();
            Timeslot timeslot = new Timeslot();

            string Day = "30-04-2022";

            timeslot.TimeslotID = 1;
            timeslot.Day = "30-04-2022";
            timeslot.Timeslots = "09:00";
            timeslot.Maxreservations = 60;

            expected.Add(timeslot);

            //Act
            List<Timeslot> actual = timeslotContainer.GetTimeslotsByDay(Day);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void Test_GetOneTimeslotById()
        {
            //Arrange
            TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDummyDAL());
            //List<Timeslot> expected = new List<Timeslot>();
            Timeslot timeslot = new Timeslot();

            int expTimeslotId = 2;
            string expDay = "30-04-2022";
            string expTimeslot = "09:00";
            int expMaxreservations = 60;

            timeslot.TimeslotID = 1;
            timeslot.Day = "30-04-2022";
            timeslot.Timeslots = "09:00";
            timeslot.Maxreservations = 60;

            //expected.Add(timeslot);

            //Act
            Timeslot actual = timeslotContainer.GetOneTimeslotById(expTimeslotId);

            //Assert
            Assert.AreEqual(expTimeslotId, actual.TimeslotID);
            Assert.AreEqual(expDay, actual.Day);
            Assert.AreEqual(expTimeslot, actual.Timeslots);
            Assert.AreEqual(expMaxreservations, actual.Maxreservations);
        }


    }
}
