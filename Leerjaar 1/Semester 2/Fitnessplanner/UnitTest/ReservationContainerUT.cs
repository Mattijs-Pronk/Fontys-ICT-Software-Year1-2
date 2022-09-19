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
    public class ReservationContainerUT
    {
        [TestMethod]
        public void Test_AddOneReservation()
        {
            //Arrange
            ReservationContainer reservationContainer = new ReservationContainer(new ReservationDummyDAL());

            int TimeslotID = 3;
            int ProgramID = 4;
            int UserID = 5;


            bool expected = true;


            //Act
            Reservation reser = new Reservation(UserID, TimeslotID, ProgramID);
            bool actual = reservationContainer.AddOneReservation(reser);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteOneReservationById()
        {
            //Arrange
            ReservationContainer reservationContainer = new ReservationContainer(new ReservationDummyDAL());

            int Id = 2;

            bool expected = true;


            //Act
            bool actual = reservationContainer.DeleteOneReservationByBookingId(Id);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteAllReservationByTimeslotId()
        {
            //Arrange
            ReservationContainer reservationContainer = new ReservationContainer(new ReservationDummyDAL());

            int Id = 2;

            bool expected = true;


            //Act
            bool actual = reservationContainer.DeleteAllReservationsByTimeslotId(Id);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteAllReservationByUserId()
        {
            //Arrange
            ReservationContainer reservationContainer = new ReservationContainer(new ReservationDummyDAL());

            int Id = 2;

            bool expected = true;


            //Act
            bool actual = reservationContainer.DeleteAllReservationsByUserId(Id);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAllReservationsById()
        {
            //Arrange
            ReservationContainer reservationContainer = new ReservationContainer(new ReservationDummyDAL());
            List<Reservation> expected = new List<Reservation>();
            Reservation reservation = new Reservation();

            reservation.TimeslotID = 2;
            reservation.ProgramID = 2;
            reservation.BookingID = 2;
            reservation.UserID = 2;

            expected.Add(reservation);


            //Act
            List<Reservation> actual = reservationContainer.GetAllReservationsById(reservation.UserID);


            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void Test_GetAllReservations()
        {
            //Arrange
            ReservationContainer reservationContainer = new ReservationContainer(new ReservationDummyDAL());
            List<Reservation> expected = new List<Reservation>();
            Reservation reservation = new Reservation();

            reservation.BookingID = 2;
            reservation.TimeslotID = 3;
            reservation.ProgramID = 4;
            reservation.UserID = 5;

            expected.Add(reservation);


            //Act
            List<Reservation> actual = reservationContainer.GetAllReservations();


            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void Test_CanUserReserveTimeslot()
        {
            //Arrange
            ReservationContainer reservationContainer = new ReservationContainer();
            User user = new User(2013, "03-01-2022", "05-08-2022");

            string currentDay = "05-06-2022";
            int currentRes = 34;
            int maxRes = 60;
            int timeslotId = 5;

            bool expected = true;


            //Act
            bool actual = reservationContainer.CanUserReserveTimeslot(user, currentDay, currentRes, maxRes, timeslotId);


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
