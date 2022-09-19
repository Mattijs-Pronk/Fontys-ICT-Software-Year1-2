using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class ProgramAndMachineViewModel
    {
        public List<MachineViewModel> machines = new List<MachineViewModel>();

        public ProgramMachineViewModel program { get; set; }

        public MachineViewModel machine { get; set; }
    }
}
