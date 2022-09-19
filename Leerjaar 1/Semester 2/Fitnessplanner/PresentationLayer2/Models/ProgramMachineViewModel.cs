using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class ProgramMachineViewModel
    {
        [Key]
        public int ProgramMachineID { get; set; }
        public int MachineID { get; set; }
        public int ProgramID { get; set; }
        public string Machinetype { get; set; }
        public string Machinename { get; set; }
        public string Machinedescription { get; set; }
        public string Programname { get; set; }
        public string Programdescription { get; set; }

        public ProgramMachineViewModel()
        {

        }

        public ProgramMachineViewModel(string programname)
        {
            this.Programname = programname;
        }

        public ProgramMachineViewModel(int programid, string programname, string programdescription)
        {
            this.ProgramID = programid;
            this.Programname = programname;
            this.Programdescription = programdescription;
        }

        public ProgramMachineViewModel(int programId, string machinetype, string machinename, string machinedescription)
        {
            this.ProgramID = programId;
            this.Machinetype = machinetype;
            this.Machinename = machinename;
            this.Machinedescription = machinedescription;
        }
    }
}
