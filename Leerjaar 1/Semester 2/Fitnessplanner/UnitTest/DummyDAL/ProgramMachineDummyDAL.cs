using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.DummyDAL
{
    class ProgramMachineDummyDAL : IProgramMachine, IProgramMachineContainer
    {
        List<ProgramMachineDTO> list = new List<ProgramMachineDTO>();

        public bool AddMachineToProgramById(ProgramMachineDTO dto)
        {
            if(dto.ProgramID == 2 && dto.MachineID == 3)
            {
                return true;
            }
            else { return false; }
        }

        public bool DeleteOneProgramMachineByProgramId(int id)
        {
            if (id == 2)
            {
                return true;
            }
            else { return false; }
        }

        public bool DeleteOneProgramMachineByProgramMachineId(int id)
        {
            if (id == 2)
            {
                return true;
            }
            else { return false; }
        }

        public List<ProgramMachineDTO> GetAllProgramMachinesById(int id)
        {
            if(id == 5)
            {
                ProgramMachineDTO dto = new ProgramMachineDTO();
                dto.ProgramMachineID = 2;
                dto.ProgramID = 3;
                dto.MachineID = 4;

                list.Add(dto);
                return list;
            }
            else { return null; }
        }

        public ProgramMachineDTO GetOneProgramMachines(ProgramMachineDTO dto)
        {
            if (dto.ProgramID == 2 && dto.MachineID == 3)
            {
                ProgramMachineDTO programMachine = new ProgramMachineDTO();
                programMachine.ProgramMachineID = 5;
                programMachine.ProgramID = 2;
                programMachine.MachineID = 3;

                return programMachine;
            }
            else { return null; }
        }
    }
}
