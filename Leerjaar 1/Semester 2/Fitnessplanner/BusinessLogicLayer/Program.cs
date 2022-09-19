using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class Program
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDescription { get; set; }

        IProgram IProgram;

        public Program()
        {

        }

        public Program(IProgram dal)
        {
            IProgram = dal;
        }

        public Program(string programname, string programdescription)
        {
            this.ProgramName = programname;
            this.ProgramDescription = programdescription;
        }

        public Program(ProgramDTO dto)
        {
            this.ProgramId = dto.ProgramId;
            this.ProgramName = dto.Programname;
            this.ProgramDescription = dto.Programdescription;
        }

        /// <summary>
        /// Methode om ingestuurde gegevens aan de DTO mee te geven.
        /// </summary>
        /// <returns>ingevulde DTO</returns>
        public ProgramDTO ToDTO()
        {
            ProgramDTO dto = new ProgramDTO();
            dto.ProgramId = ProgramId;
            dto.Programname = ProgramName;
            dto.Programdescription = ProgramDescription;
            return dto;
        }
    }
}
