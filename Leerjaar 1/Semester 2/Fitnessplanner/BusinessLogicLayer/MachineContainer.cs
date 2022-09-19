using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class MachineContainer
    {
        IMachineContainer IMachineContainer;

        public MachineContainer()
        {

        }

        public MachineContainer(IMachineContainer dal)
        {
            IMachineContainer = dal;
        }

        /// <summary>
        /// Methode om een machine met bijbehorende gegevens aan te maken.
        /// </summary>
        /// <param name="machine">object van machine die toegevoegd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneMachine(Machine machine)
        {
            MachineDTO dto = machine.ToDTO();
            return IMachineContainer.AddOneMachine(dto);
        }

        //Methode om een machine te verwijderen.
        /// <summary>
        /// methode om machine met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Machineid van machine die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneMachineById(int id)
        {
            return IMachineContainer.DeleteOneMachineById(id);
        }

        /// <summary>
        /// Methode om een machine op te halen.
        /// </summary>
        /// <param name="id">Machineid van machine die opgehaald moet worden</param>
        /// <returns>object van machine</returns>
        public Machine GetOneMachineById(int id)
        {
            return new Machine(IMachineContainer.GetOneMachineById(id));
        }

        /// <summary>
        /// Methode om machine op te halen
        /// </summary>
        /// <param name="searchPhrase">MachineName van machine die opgehaald moet worden</param>
        /// <returns>object van machine</returns>
        public Machine GetOneMachineByMachineName(string searchPhrase)
        {
            return new Machine(IMachineContainer.GetOneMachineByMachineName(searchPhrase));
        }

        /// <summary>
        /// Methode om machines op te halen.
        /// </summary>
        /// <param name="SearchPhrase">Machinetype van machines die opgehaald moeten worden</param>
        /// <returns></returns>
        public List<Machine> GetAllMachinesByMachineType(string SearchPhrase)
        {
            //List aanmaken en vullen.
            List<Machine> allmachines = new List<Machine>();
            List<MachineDTO> listmachines = IMachineContainer.GetAllMachinesByMachineType(SearchPhrase);

            foreach (MachineDTO machines in listmachines)
            {
                Machine newmachines = new Machine(machines);
                allmachines.Add(newmachines);
            }
            return allmachines;
        }

        /// <summary>
        /// list om alle machines met bijbehoren weer te geven.
        /// </summary>
        /// <returns>list van machines</returns>
        public List<Machine> GetAllMachines()
        {
            //List aanmaken en vullen.
            List<Machine> allmachines = new List<Machine>();
            List<MachineDTO> listmachines = IMachineContainer.GetAllMachines();

            foreach (MachineDTO machines in listmachines)
            {
                Machine newmachines = new Machine(machines);
                allmachines.Add(newmachines);
            }
            return allmachines;
        }
    }
}
