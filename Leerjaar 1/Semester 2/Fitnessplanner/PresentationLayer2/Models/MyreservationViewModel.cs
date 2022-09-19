using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class MyreservationViewModel
    {
        [Key]
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int TimeslotID { get; set; }
        public string Day { get; set; }
        public string Timeslot { get; set; }
        public int Currentreservation { get; set; }
        public int Maxreservations { get; set; }
        public string Programname { get; set; }

        public int ProgramId { get; set; }

        public MyreservationViewModel()
        {

        }

        public MyreservationViewModel(string programname)
        {
            this.Programname = programname;
        }

        public MyreservationViewModel(int bookingid, int userid, int timeslotid, string day, string timeslot, int currentres, int maxres, string programname)
        {
            this.BookingID = bookingid;
            this.UserID = userid;
            this.TimeslotID = timeslotid;
            this.Day = day;
            this.Timeslot = timeslot;
            this.Currentreservation = currentres;
            this.Maxreservations = maxres;
            this.Programname = programname;
        }
    }
}
