using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class ProgramContainer
    {
        IProgramContainer IProgramContainer;

        public ProgramContainer()
        {
        }

        public ProgramContainer(IProgramContainer dal)
        {
            IProgramContainer = dal;
        }

        /// <summary>
        /// Methode om een programma toe te voegen
        /// </summary>
        /// <param name="program">object van programma die toegevoegd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneProgram(Program program)
        {
            ProgramDTO dto = program.ToDTO();
            return IProgramContainer.AddOneProgram(dto);
        }

        /// <summary>
        /// Methode om een programma te verwijderen
        /// </summary>
        /// <param name="id">ProgramId van programma die verwijdert moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneProgramById(int id)
        {
            return IProgramContainer.DeleteOneProgramById(id);
        }

        /// <summary>
        /// Methode om enkel programma op te halen met programName
        /// </summary>
        /// <param name="searchPhrase">ProgramName van programma die opgehaald moet worden</param>
        /// <returns>object van programma</returns>
        public Program GetOneProgramByName(string searchPhrase)
        {
            return new Program(IProgramContainer.GetOneProgramByName(searchPhrase));
        }

        /// <summary>
        /// Methode om enkel programma op te halen met programId
        /// </summary>
        /// <param name="id">ProgramId van programma die opgehaald moet worden</param>
        /// <returns>object van programma</returns>
        public Program GetOneProgramById(int id)
        {
            return new Program(IProgramContainer.GetOneProgramById(id));
        }

        /// <summary>
        /// Methode om een list met alle programma's op te halen
        /// </summary>
        /// <returns>list van alle programmas</returns>
        public List<Program> GetAllPrograms()
        {
            //list aanmaken en vullen.
            List<Program> allprograms = new List<Program>();
            List<ProgramDTO> listall = IProgramContainer.GetAllPrograms();

            foreach (ProgramDTO programs in listall)
            {
                Program newprogram = new Program(programs);
                allprograms.Add(newprogram);
            }
            return allprograms;
        }
    }
}
