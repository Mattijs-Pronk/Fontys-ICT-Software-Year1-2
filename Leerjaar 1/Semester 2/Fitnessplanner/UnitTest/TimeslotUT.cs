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
    public class TimeslotUT
    {
        [TestMethod]
        public void Test_ToDTO()
        {
            //Arrange
            Timeslot timeslot = new Timeslot();
            TimeslotDTO dto = new TimeslotDTO();

            timeslot.TimeslotID = 2;
            timeslot.Day = "30-04-2022";
            timeslot.Timeslots = "09:00";
            timeslot.Maxreservations = 60;

            int expectedId = 2;
            string expectedDay = "30-04-2022";
            string expectedTimeslot = "09:00";
            int expectedMaxreservations = 60;

            //Act
            dto = timeslot.ToDTO();

            //Assert
            Assert.AreEqual(expectedId, dto.TimeslotID);
            Assert.AreEqual(expectedDay, dto.Day);
            Assert.AreEqual(expectedTimeslot, dto.Timeslot);
            Assert.AreEqual(expectedMaxreservations, dto.Maxreservations);
        }

        [TestMethod]
        public void Test_EditOneTimeslotById()
        {
            //Arrange
            Timeslot timeslot = new Timeslot(new TimeslotDummyDAL());

            int Id = 2;
            string Day = "30-04-2022";
            string Timeslot = "09:00";
            int Maxreservations = 60;

            bool expected = true;

            //Act
            Timeslot time = new Timeslot(Id, Day, Timeslot, Maxreservations);
            bool actual = timeslot.EditOneTimeslotById(time);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
