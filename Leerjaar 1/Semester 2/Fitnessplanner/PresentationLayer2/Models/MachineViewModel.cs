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

        public MachineViewModel()
        {

        }

        public MachineViewModel(int machineid, string machinename)
        {
            this.MachineId = machineid;
            this.Machinename = machinename;
        }

        public MachineViewModel(int id, string machinetype, string machinename, string machinedescription)
        {
            this.MachineId = id;
            this.Machinetype = machinetype;
            this.Machinename = machinename;
            this.Machinedescription = machinedescription;
        }
    }
}
