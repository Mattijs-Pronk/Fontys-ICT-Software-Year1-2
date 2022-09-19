using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace DatabaseLayer
{
    public class ReservationDAL : SqlConnect, IReservationContainer, IReservation
    {
        public ReservationDAL()
        {
            Initialize();
        }

        /// <summary>
        /// Methode om een reservering toe te voegen
        /// </summary>
        /// <param name="dto">dto van reservering die opgehaald moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneReservation(ReservationDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO Reservations (UserID, TimeslotID, ProgramID) VALUES (@UserID, @TimeslotID, @ProgramID)";
                cmd.Parameters.AddWithValue("@UserID", dto.UserID);
                cmd.Parameters.AddWithValue("@TimeslotID", dto.TimeslotID);
                cmd.Parameters.AddWithValue("@ProgramID", dto.ProgramID);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// methode om reservering met programma gegevens te bewerken.
        /// </summary>
        /// <param name="dto">dto van reservering die geupdate moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool EditOneReservationById(ReservationDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "UPDATE Reservations SET ProgramID = @ProgramID WHERE BookingID = @BookingID";

                cmd.Parameters.AddWithValue("@BookingID", dto.BookingID);
                cmd.Parameters.AddWithValue("@ProgramID", dto.ProgramID);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Methode om de huidige reserveringen te checken/berekenen.
        /// </summary>
        /// <param name="Id">Timeslotid van reservering waarvan currentreservations moet worden gechecked</param>
        /// <returns>Int van currentreservations</returns>
        public int CurrentReservations(int Id)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT COUNT(1) FROM Reservations WHERE TimeslotID = @TimeslotID";

            cmd.Parameters.AddWithValue("@TimeslotID", Id);

            Int32 currentres = (Int32)cmd.ExecuteScalar();

            CloseConnect();

            return currentres;
        }

        /// <summary>
        /// list aanmaken die alle bookingen met bijbehorende gegevens ophaalt.
        /// </summary>
        /// <param name="id">userid van reservering waarvan een object moet worden gemaakt</param>
        /// <returns>object van reservering</returns>
        public List<ReservationDTO> GetAllReservationsById(int id)
        {
            OpenConnect();

            cmd.Parameters.Clear();
            
            cmd.CommandText = "SELECT * FROM Reservations INNER JOIN TimeSlots ON Reservations.TimeslotID = TimeSlots.TimeslotID Inner JOIN Programs ON Reservations.ProgramID = Programs.ProgramID WHERE Reservations.UserID = @UserID";
            //"Inner JOIN Programs ON Reservations.ProgramID = Programs.ProgramID"
            cmd.Parameters.AddWithValue("@UserID", id);

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<ReservationDTO> listall = new List<ReservationDTO>();

            while (rdr.Read())
            {
                ReservationDTO reservation = new ReservationDTO()
                {
                    BookingID = rdr.GetInt32("BookingID"),
                    UserID = rdr.GetInt32("UserID"),
                    TimeslotID = rdr.GetInt32("TimeslotID"),
                    ProgramID = rdr.GetInt32("ProgramID"),
                };

                TimeslotDTO timeslot = new TimeslotDTO()
                {
                    Day = rdr.GetString("Day"),
                    Timeslot = rdr.GetString("Timeslot"),
                    Maxreservations = rdr.GetInt32("MaxReservations"),
                };

                ProgramDTO program = new ProgramDTO()
                {
                    Programname = rdr.GetString("ProgramName"),
                };

                reservation.Timeslot = timeslot;
                reservation.Program = program;
                listall.Add(reservation);
            }
            CloseConnect();

            return listall;
        }

        /// <summary>
        /// list aanmaken die enkele booking met bijbehorende gegevens ophaalt.
        /// </summary>
        /// <param name="id">bookingid van reservering waarvan een object moet worden gemaakt</param>
        /// <returns></returns>
        public ReservationDTO GetOneReservationsById(int id)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Reservations INNER JOIN TimeSlots ON Reservations.TimeslotID = TimeSlots.TimeslotID Inner JOIN Programs ON Reservations.ProgramID = Programs.ProgramID WHERE Reservations.BookingID = @BookingID";
            //"Inner JOIN Programs ON Reservations.ProgramID = Programs.ProgramID"
            cmd.Parameters.AddWithValue("@BookingID", id);

            using SqlDataReader rdr = cmd.ExecuteReader();

            ReservationDTO reser = new ReservationDTO();

            while (rdr.Read())
            {
                ReservationDTO reservation = new ReservationDTO()
                {
                    BookingID = rdr.GetInt32("BookingID"),
                    UserID = rdr.GetInt32("UserID"),
                    TimeslotID = rdr.GetInt32("TimeslotID"),
                    ProgramID = rdr.GetInt32("ProgramID"),
                };

                TimeslotDTO timeslot = new TimeslotDTO()
                {
                    Day = rdr.GetString("Day"),
                    Timeslot = rdr.GetString("Timeslot"),
                    Maxreservations = rdr.GetInt32("MaxReservations"),
                };

                ProgramDTO program = new ProgramDTO()
                {
                    Programname = rdr.GetString("ProgramName"),
                };

                reservation.Timeslot = timeslot;
                reservation.Program = program;
                reser = reservation;
            }
            CloseConnect();

            return reser;
        }

        /// <summary>
        /// list aanmaken die alle bookingen met bijbehorende gegevens ophaalt.
        /// </summary>
        /// <returns>list van alle reservations</returns>
        public List<ReservationDTO> GetAllReservations()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Reservations INNER JOIN TimeSlots ON Reservations.TimeslotID = TimeSlots.TimeslotID Inner JOIN Programs ON Reservations.ProgramID = Programs.ProgramID";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<ReservationDTO> listall = new List<ReservationDTO>();

            while (rdr.Read())
            {
                ReservationDTO reservation = new ReservationDTO()
                {
                    BookingID = rdr.GetInt32("BookingID"),
                    //UserID = rdr.GetInt32("UserID"),
                    TimeslotID = rdr.GetInt32("TimeslotID"),
                    //ProgramID = rdr.GetInt32("ProgramID"),
                };

                TimeslotDTO timeslot = new TimeslotDTO
                {
                    Day = rdr.GetString("Day"),
                    Timeslot = rdr.GetString("Timeslot"),
                    Maxreservations = rdr.GetInt32("MaxReservations"),
                };

                ProgramDTO program = new ProgramDTO()
                {
                    Programname = rdr.GetString("ProgramName"),
                };

                reservation.Timeslot = timeslot;
                reservation.Program = program;
                listall.Add(reservation);
            }
            CloseConnect();

            return listall;
        }

        //
        /// <summary>
        /// methode om reservation met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Bookingid van reservering die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneReservationByBookingId(int id)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM Reservations WHERE BookingID = @BookingID";
                cmd.Parameters.AddWithValue("@BookingID", id);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// methode om reservation met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Timeslotid van reservering die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteAllReservationsByTimeslotId(int id)
        {
            if (OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM Reservations WHERE TimeslotID = @TimeslotID";
                cmd.Parameters.AddWithValue("@TimeslotID", id);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// methode om reservation met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Userid van reservering die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteAllReservationsByUserId(int id)
        {
            if (OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM Reservations WHERE UserID = @UserID";
                cmd.Parameters.AddWithValue("@UserID", id);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Methode om te controleren of userId met bijhorende ReservationId in de database staan.
        /// </summary>
        /// <param name="dto">dto van reservering die gechecked moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool CheckReservationsById(ReservationDTO dto)
        {
            try
            {
                OpenConnect();

                cmd.Parameters.Clear();

                cmd.CommandText = ("SELECT * FROM Reservations where UserID = @UserID AND TimeslotID = @TimeslotID");
                cmd.Parameters.AddWithValue("UserID", dto.UserID);
                cmd.Parameters.AddWithValue("@TimeslotID", dto.TimeslotID);

                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.HasRows)
                {
                    rdr.Read();
                    if (rdr["UserID"].ToString() == Convert.ToString(dto.UserID) || rdr["TimeslotID"].ToString() == Convert.ToString(dto.TimeslotID))
                    {
                        //bool om te checken of er een row bestaat met matchend UserId en ReservationId.
                        return true;
                    }
                }
                return false;
            }

            finally
            {
                CloseConnect();
            }
        }
    }
}
