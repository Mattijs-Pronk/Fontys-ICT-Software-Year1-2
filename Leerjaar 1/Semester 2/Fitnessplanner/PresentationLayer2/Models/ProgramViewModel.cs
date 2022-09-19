using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class ProgramViewModel
    {
        public int ProgramId { get; set; }

        public string ProgramName { get; set; }

        public string ProgramDescription { get; set; }


        public ProgramViewModel()
        {

        }

        public ProgramViewModel(string programname)
        {
            this.ProgramName = programname;
        }
    }
}
