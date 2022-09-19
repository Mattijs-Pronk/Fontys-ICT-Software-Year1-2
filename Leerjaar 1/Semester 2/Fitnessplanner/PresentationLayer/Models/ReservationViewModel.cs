using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class ReservationViewModel
    {
        [Key]
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int TimeslotID { get; set; }
        public int ProgramID { get; set; }
        public int Currentreservation { get; set; }
        public Timeslot Timeslot { get; set; }
        public Program Program { get; set; }
    }

    public class Timeslot
    {
        [Key]
        public int TimeslotID { get; set; }
        public string Day { get; set; }
        public string Timeslots { get; set; }
        public int Currentreservations { get; set; }
        public int Maxreservations { get; set; }
    }

    public class Program
    {
        [Key]
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDescription { get; set; }
    }
}
