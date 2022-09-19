using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class Reservation
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int TimeslotID { get; set; }
        public int ProgramID { get; set; }
        public int Currentreservations { get; set; }
        public TimeslotDTO Timeslot { get; set; }
        public ProgramDTO Program { get; set; }

        IReservation IReservation;

        public Reservation()
        {

        }

        public Reservation(int userId, int timeslotId)
        {
            this.UserID = userId;
            this.TimeslotID = timeslotId;

            this.BookingID = userId;
            this.ProgramID = timeslotId;
        }

        public Reservation(int userId, int timeslotId, int programId)
        {
            this.UserID = userId;
            this.TimeslotID = timeslotId;
            this.ProgramID = programId;
        }

        public Reservation(IReservation dal)
        {
            IReservation = dal;
        }

        public Reservation(ReservationDTO dto)
        {
            this.BookingID = dto.BookingID;
            this.UserID = dto.UserID;
            this.TimeslotID = dto.TimeslotID;
            this.ProgramID = dto.ProgramID;

            this.Timeslot = dto.Timeslot;

            this.Program = dto.Program;
        }

        /// <summary>
        /// Methode om ingestuurde gegevens aan de DTO mee te geven.
        /// </summary>
        /// <returns>ingevulde DTO</returns>
        public ReservationDTO ToDTO()
        {
            ReservationDTO dto = new ReservationDTO();
            dto.BookingID = BookingID;
            dto.UserID = UserID;
            dto.TimeslotID = TimeslotID;
            dto.ProgramID = ProgramID;
            return dto;
        }

        /// <summary>
        /// Methode om de huidige reserveringen te checken/berekenen.
        /// </summary>
        /// <param name="Id">Timeslotid van reservering waarvan currentreservations moet worden gechecked</param>
        /// <returns>Int van currentreservations</returns>
        public int CurrentReservations(int Id)
        {
            return IReservation.CurrentReservations(Id);
        }

        /// <summary>
        /// methode om reservering met programma gegevens te bewerken.
        /// </summary>
        /// <param name="reservation">object van reservering die geupdate moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool EditOneReservationById(Reservation reservation)
        {
            ReservationDTO dto = reservation.ToDTO();
            return IReservation.EditOneReservationById(dto);
        }

        /// <summary>
        /// Methode om te controleren of userId met bijhorende ReservationId in de database staan.
        /// </summary>
        /// <param name="reservation">object van reservering die gechecked moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool CheckReservationsById(Reservation reservation)
        {
            ReservationDTO dto = reservation.ToDTO();
            return IReservation.CheckReservationsById(dto);
        }
    }
}
