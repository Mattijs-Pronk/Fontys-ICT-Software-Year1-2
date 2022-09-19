using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class ProgramMachine
    {
        public int ProgramMachineID { get; set; }
        public int MachineID { get; set; }
        public int ProgramID { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDescription { get; set; }
        public ProgramDTO Program { get; set; }
        public MachineDTO Machine { get; set; }

        IProgramMachine IProgramMachine;

        public ProgramMachine()
        {

        }

        public ProgramMachine(int programid, int machineid)
        {
            this.ProgramID = programid;
            this.MachineID = machineid;
        }

        public ProgramMachine(int programid, string programname, string programdescription)
        {
            this.ProgramID = programid;
            this.ProgramName = programname;
            this.ProgramDescription = programdescription;
        }

        public ProgramMachine(IProgramMachine dal)
        {
            IProgramMachine = dal;
        }

        public ProgramMachine(ProgramMachineDTO dto)
        {
            this.ProgramMachineID = dto.ProgramMachineID;
            this.MachineID = dto.MachineID;
            this.ProgramID = dto.ProgramID;

            this.Machine = dto.Machine;
            this.Program = dto.Program;
        }

        /// <summary>
        /// Methode om ingestuurde gegevens aan de DTO mee te geven.
        /// </summary>
        /// <returns>ingevulde DTO</returns>
        public ProgramMachineDTO ToDTO()
        {
            ProgramMachineDTO dto = new ProgramMachineDTO();
            dto.ProgramMachineID = ProgramMachineID;
            dto.MachineID = MachineID;
            dto.ProgramID = ProgramID;
            
            return dto;
        }
    }
}
