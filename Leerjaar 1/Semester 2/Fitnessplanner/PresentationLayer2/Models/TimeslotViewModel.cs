using BusinessLogicLayer;
using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class TimeslotViewModel
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

        public TimeslotViewModel()
        {

        }

        public TimeslotViewModel(int id, string day, string timeslots, int currentres, int maxres)
        {
            this.TimeslotID = id;
            this.Day = day;
            this.Timeslots = timeslots;
            this.Currentreservations = currentres;
            this.Maxreservations = maxres;
        }
    }
}
