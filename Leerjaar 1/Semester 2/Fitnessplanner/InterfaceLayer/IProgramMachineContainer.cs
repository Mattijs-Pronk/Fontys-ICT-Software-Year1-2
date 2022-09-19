using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IProgramMachineContainer
    {
        public bool AddMachineToProgramById(ProgramMachineDTO dto);

        public bool DeleteOneProgramMachineByProgramId(int id);

        public bool DeleteOneProgramMachineByProgramMachineId(int id);

        public ProgramMachineDTO GetOneProgramMachines(ProgramMachineDTO dto);

        public List<ProgramMachineDTO> GetAllProgramMachinesById(int id);
    }
}
