using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class MachineAndMyreservationViewModel
    {

        public List<MachineViewModel> machines = new List<MachineViewModel>();

        public MyreservationViewModel myreservation { get; set; }
    }
}
