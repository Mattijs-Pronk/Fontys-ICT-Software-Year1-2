using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class ReservationContainer
    {
        IReservationContainer IBookingtimeslotContainer;

        public ReservationContainer()
        {
        }

        public ReservationContainer(IReservationContainer dal)
        {
            IBookingtimeslotContainer = dal;
        }

        /// <summary>
        /// Methode om een reservering toe te voegen
        /// </summary>
        /// <param name="reservation">object van reservering</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneReservation(Reservation reservation)
        {
            ReservationDTO dto = reservation.ToDTO();
            return IBookingtimeslotContainer.AddOneReservation(dto);
        }

        /// <summary>
        /// list aanmaken die alle bookingen met bijbehorende gegevens ophaalt.
        /// </summary>
        /// <param name="id">Userid van reserveringen die opgehaald moet worden</param>
        /// <returns>list van reservations</returns>
        public List<Reservation> GetAllReservationsById(int id)
        {
            //List aanmaken en invullen.
            List<Reservation> bookings = new List<Reservation>();
            List<ReservationDTO> listall = IBookingtimeslotContainer.GetAllReservationsById(id);

            foreach (ReservationDTO booking in listall)
            {
                Reservation newbooking = new Reservation(booking);
                bookings.Add(newbooking);
            }

            return bookings;
        }

        /// <summary>
        /// object aanmaken van een booking met bijbehorende gegevens.
        /// </summary>
        /// <param name="id">Bookingid van reservering die opgehaald moet worden</param>
        /// <returns>object van reservation</returns>
        public Reservation GetOneReservationsById(int id)
        {
            return new Reservation(IBookingtimeslotContainer.GetOneReservationsById(id));
        }

        /// <summary>
        /// list aanmaken die alle bookingen met bijbehorende gegevens ophaalt.
        /// </summary>
        /// <returns>list van alle reservations</returns>
        public List<Reservation> GetAllReservations()
        {
            //List aanmaken en invullen.
            List<Reservation> bookings = new List<Reservation>();
            List<ReservationDTO> listall = IBookingtimeslotContainer.GetAllReservations();

            foreach (ReservationDTO booking in listall)
            {
                Reservation newbooking = new Reservation(booking);
                bookings.Add(newbooking);
            }

            return bookings;
        }

        /// <summary>
        /// methode om reservation met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Bookingid van reservering die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneReservationByBookingId(int id)
        {
            return IBookingtimeslotContainer.DeleteOneReservationByBookingId(id);
        }

        /// <summary>
        /// methode om reservation met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Timeslotid van reservering die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteAllReservationsByTimeslotId(int id)
        {
            return IBookingtimeslotContainer.DeleteAllReservationsByTimeslotId(id);
        }

        /// <summary>
        /// methode om reservation met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Userid van reservering die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteAllReservationsByUserId(int id)
        {
            return IBookingtimeslotContainer.DeleteAllReservationsByUserId(id);
        }

        Reservation reservation = new Reservation(new ReservationDAL());
        
        /// <summary>
        /// Methode om te checken of een reservering gemaakt kan worden
        /// </summary>
        /// <param name="user">gegevens van user</param>
        /// <param name="selectedDay">gekozen dag</param>
        /// <param name="currentRes">huidige reserveringen</param>
        /// <param name="maxRes">maximale reserveringen</param>
        /// <param name="timeslotId">gekozen timeslotid</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool CanUserReserveTimeslot(User user, string selectedDay, int currentRes, int maxRes, int timeslotId)
        {
            //is het abbonement nog geldig?
            if (Convert.ToDateTime(user.SubscriptionEnd) < Convert.ToDateTime(selectedDay)) { return false; }

            //is er nog ruimte voor een extra reservering?
            if (currentRes >= maxRes) { return false; }

            //heeft user al een reservering op dit tijdstip?
            Reservation reser = new Reservation(user.Id, timeslotId);
            if (reservation.CheckReservationsById(reser) == true) { return false; }

            return true;
        }
    }
}
