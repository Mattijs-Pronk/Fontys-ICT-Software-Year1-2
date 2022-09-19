using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string Machinetype { get; set; }
        public string Machinename { get; set; }
        public string Machinedescription { get; set; }

        IMachine IMachine;

        public Machine()
        {

        }

        public Machine(int machineId)
        {
            this.MachineId = machineId;
        }

        public Machine(string machinetype, string machinename, string machinedescription)
        {
            this.Machinetype = machinetype;
            this.Machinename = machinename;
            this.Machinedescription = machinedescription;
        }

        public Machine(int machineId, string machinetype, string machinename, string machinedescription)
        {
            this.MachineId = machineId;
            this.Machinetype = machinetype;
            this.Machinename = machinename;
            this.Machinedescription = machinedescription;
        }

        public Machine(IMachine dal)
        {
            IMachine = dal;
        }

        public Machine(MachineDTO dto)
        {
            this.MachineId = dto.MachineId;
            this.Machinetype = dto.Machinetype;
            this.Machinename = dto.Machinename;
            this.Machinedescription = dto.Machinedescription;
        }

        /// <summary>
        /// Methode om ingestuurde gegevens aan de DTO mee te geven.
        /// </summary>
        /// <returns>ingevulde DTO</returns>
        public MachineDTO ToDTO()
        {
            MachineDTO dto = new MachineDTO();
            dto.MachineId = MachineId;
            dto.Machinetype = Machinetype;
            dto.Machinename = Machinename;
            dto.Machinedescription = Machinedescription;
            return dto;
        }

        /// <summary>
        /// methode om machine met bijbehorende gegevens te bewerken.
        /// </summary>
        /// <param name="machine">object van machine die geupdate moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool EditOneMachineById(Machine machine)
        {
            MachineDTO dto = machine.ToDTO();
            return IMachine.EditOneMachineById(dto);
        }
    }
}
