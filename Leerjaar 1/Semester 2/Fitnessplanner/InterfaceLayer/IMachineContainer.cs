using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IMachineContainer
    {
        public bool AddOneMachine(MachineDTO dto);

        public bool DeleteOneMachineById(int id);

        public MachineDTO GetOneMachineById(int id);

        public MachineDTO GetOneMachineByMachineName(string searchPhrase);

        public List<MachineDTO> GetAllMachinesByMachineType(string SearchPhrase);

        public List<MachineDTO> GetAllMachines();
    }
}
