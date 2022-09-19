using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class Timeslot
    {
        public int TimeslotID { get; set; }
        public string Day { get; set; }
        public string Timeslots { get; set; }
        public int Currentreservations { get; set; }
        public int Maxreservations { get; set; }

        ITimeslot ITimeslot;

        public Timeslot()
        {

        }

        public Timeslot(ITimeslot dal)
        {
            ITimeslot = dal;
        }

        public Timeslot(string day, string timeslot, int maxres)
        {
            this.Day = day;
            this.Timeslots = timeslot;
            this.Maxreservations = maxres;
        }

        public Timeslot(int timeslotId, string day, string timeslot, int maxres)
        {
            this.TimeslotID = timeslotId;
            this.Day = day;
            this.Timeslots = timeslot;
            this.Maxreservations = maxres;
        }

        Reservation reservation = new Reservation(new ReservationDAL());
        public Timeslot(TimeslotDTO dto)
        {
            this.TimeslotID = dto.TimeslotID;
            this.Day = dto.Day;
            this.Timeslots = dto.Timeslot;
            this.Currentreservations = reservation.CurrentReservations(TimeslotID);
            this.Maxreservations = dto.Maxreservations;
        }

        /// <summary>
        /// Methode om ingestuurde gegevens aan de DTO mee te geven.
        /// </summary>
        /// <returns>ingevulde DTO</returns>
        public TimeslotDTO ToDTO()
        {
            TimeslotDTO dto = new TimeslotDTO();
            dto.TimeslotID = TimeslotID;
            dto.Day = Day;
            dto.Timeslot = Timeslots;
            dto.Maxreservations = Maxreservations;
            return dto;
        }

        /// <summary>
        /// Methode om een timeslot met bijbehoren te bewerken.
        /// </summary>
        /// <param name="timeslot">object van timeslot die aangepast moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool EditOneTimeslotById(Timeslot timeslot)
        {
            TimeslotDTO dto = timeslot.ToDTO();
            return ITimeslot.EditOneTimeslotById(dto);
        }
    }
}
