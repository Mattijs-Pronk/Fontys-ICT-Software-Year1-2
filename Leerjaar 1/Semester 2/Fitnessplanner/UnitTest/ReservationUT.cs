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
    public class ReservationUT
    {
        [TestMethod]
        public void Test_ToDTO()
        {
            //Arrange
            Reservation reservation = new Reservation();
            ReservationDTO dto = new ReservationDTO();

            reservation.BookingID = 2;
            reservation.TimeslotID = 3;
            reservation.ProgramID = 4;
            reservation.UserID = 5;

            int expectedBookingId = 2;
            int expectedTimeslotId = 3;
            int expectedProgramId = 4;
            int expectedUserId = 5;

            //Act
            dto = reservation.ToDTO();

            //Assert
            Assert.AreEqual(expectedBookingId, dto.BookingID);
            Assert.AreEqual(expectedTimeslotId, dto.TimeslotID);
            Assert.AreEqual(expectedProgramId, dto.ProgramID);
            Assert.AreEqual(expectedUserId, dto.UserID);
        }

        [TestMethod]
        public void Test_EditOneReservationById()
        {
            //Arrange
            Reservation reservation = new Reservation(new ReservationDummyDAL());

            int UserID = 5;
            int BookingID = 2;

            bool expected = true;

            //Act
            Reservation reser = new Reservation(UserID, BookingID);
            bool actual = reservation.EditOneReservationById(reser);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CurrentReservations()
        {
            //Arrange
            Reservation reservation = new Reservation(new ReservationDummyDAL());

            int TimeslotID = 5;

            int expected = 9;

            //Act
            int actual = reservation.CurrentReservations(TimeslotID);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckReservationsById()
        {
            //Arrange
            Reservation reservation = new Reservation(new ReservationDummyDAL());

            int UserID = 5;
            int TimeslotID = 2;

            bool expected = true;

            //Act
            Reservation reser = new Reservation(UserID, TimeslotID);
            bool actual = reservation.CheckReservationsById(reser);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
