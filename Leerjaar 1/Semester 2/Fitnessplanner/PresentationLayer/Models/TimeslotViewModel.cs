using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class TimeslotViewModel
    {
        [Key]
        public int TimeslotID { get; set; }
        public string Day { get; set; }
        public string Timeslots { get; set; }
        public int Currentreservations { get; set; }
        public int Maxreservations { get; set; }
    }
}
