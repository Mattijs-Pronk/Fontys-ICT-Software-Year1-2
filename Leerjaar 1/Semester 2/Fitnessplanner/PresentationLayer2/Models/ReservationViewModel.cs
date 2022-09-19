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
        public int TimeslotID { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string Timeslots { get; set; }
        [Required]
        public int Currentreservations { get; set; }
        [Required]
        public int Maxreservations { get; set; }

        public ReservationViewModel()
        {

        }

        public ReservationViewModel(int timeslotId, string day, string timeslot, int currentres, int maxres)
        {
            this.TimeslotID = timeslotId;
            this.Day = day;
            this.Timeslots = timeslot;
            this.Currentreservations = currentres;
            this.Maxreservations = maxres;
        }
    }
}
