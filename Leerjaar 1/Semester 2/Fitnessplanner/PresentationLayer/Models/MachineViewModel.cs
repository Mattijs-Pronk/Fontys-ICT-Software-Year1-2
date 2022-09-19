using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class MachineViewModel
    {
        [Key]
        public int MachineId { get; set; }
        [Required]
        public string Machinetype { get; set; }
        [Required]
        public string Machinename { get; set; }
        [Required]
        public string Machinedescription { get; set; }
    }
}
