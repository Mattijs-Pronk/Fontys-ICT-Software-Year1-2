using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ProgramMachineContainer
    {
        IProgramMachineContainer IProgramMachineContainer;

        public ProgramMachineContainer()
        {

        }

        public ProgramMachineContainer(IProgramMachineContainer dal)
        {
            IProgramMachineContainer = dal;
        }

        /// <summary>
        /// Methode om machine toe te voegen aan programma
        /// </summary>
        /// <param name="programMachine">object van machine die toegevoegd moet worden aan programma</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddMachineToProgramById(ProgramMachine programMachine)
        {
            ProgramMachineDTO dto = programMachine.ToDTO();
            return IProgramMachineContainer.AddMachineToProgramById(dto);
        }

        /// <summary>
        /// Methode om een program te verwijderen van programma
        /// </summary>
        /// <param name="id">Programid van programma die verwijderd moet worden</param>
        /// <returns>true wanneer gelukt, false wanneer niet gelukt</returns>
        public bool DeleteOneProgramMachineByProgramId(int id)
        {
            return IProgramMachineContainer.DeleteOneProgramMachineByProgramId(id);
        }

        /// <summary>
        /// Methode om een machine te verwijderen van programma
        /// </summary>
        /// <param name="id">ProgramMachineid van programma die verwijderd moet worden</param>
        /// <returns>true wanneer gelukt, false wanneer niet gelukt</returns>
        public bool DeleteOneProgramMachineByProgramMachineId(int id)
        {
            return IProgramMachineContainer.DeleteOneProgramMachineByProgramMachineId(id);
        }

        /// <summary>
        /// Methode om een enkel programma met bijbehorende machines op te halen
        /// </summary>
        /// <param name="programMachine">object van programma die opgehaald moet worden</param>
        /// <returns>object van programma met machines</returns>
        public ProgramMachine GetOneProgramMachines(ProgramMachine programMachine)
        {
            ProgramMachineDTO dto = programMachine.ToDTO();
            return new ProgramMachine(IProgramMachineContainer.GetOneProgramMachines(dto));
        }

        /// <summary>
        /// Methode om alle Programmas met bijbehorende machines op te halen.
        /// </summary>
        /// <param name="id">Programid van machines in een program die moeten worden opgehaald</param>
        /// <returns>list van alle programmas met gelinkte machines</returns>
        public List<ProgramMachine> GetAllProgramMachinesById(int id)
        {
            //List aanmaken en invullen.
            List<ProgramMachine> programs = new List<ProgramMachine>();
            List<ProgramMachineDTO> listall = IProgramMachineContainer.GetAllProgramMachinesById(id);

            foreach (ProgramMachineDTO program in listall)
            {
                ProgramMachine newprogram = new ProgramMachine(program);
                programs.Add(newprogram);
            }

            return programs;
        }
    }
}
