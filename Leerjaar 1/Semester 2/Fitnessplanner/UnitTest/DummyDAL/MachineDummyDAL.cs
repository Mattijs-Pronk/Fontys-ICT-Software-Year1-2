using BusinessLogicLayer;
using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class MachineDummyDAL : IMachine, IMachineContainer
    {
        List<MachineDTO> list = new List<MachineDTO>();

        public bool AddOneMachine(MachineDTO dto)
        {
            try
            {
                if(dto.Machinetype == "Tricep") {list.Add(dto); return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool DeleteOneMachineById(int id)
        {
            try
            {
                if(id == 2) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool EditOneMachineById(MachineDTO dto)
        {
            try
            {
                if(dto.MachineId == 5) {
                    return true;
                }
                else { return false; }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public List<MachineDTO> GetAllMachines()
        {
            MachineDTO dto = new MachineDTO();
            dto.MachineId = 2;
            dto.Machinetype = "Bicep";
            dto.Machinename = "Bicep extension";
            dto.Machinedescription = "Machine to train biceps";

            list.Add(dto);
            return list;
        }

        public List<MachineDTO> GetAllMachinesByMachineType(string SearchPhrase)
        {
            if(SearchPhrase == "Tricep")
            {
                MachineDTO dto = new MachineDTO();
                dto.MachineId = 2;
                dto.Machinetype = "Bicep";
                dto.Machinename = "Bicep extension";
                dto.Machinedescription = "Machine to train biceps";

                list.Add(dto);
                return list;
            }
            else { return null; }
        }

        public MachineDTO GetOneMachineById(int id)
        {
            if(id == 2)
            {
                MachineDTO mach = new MachineDTO();
                mach.MachineId = 2;
                mach.Machinetype = "Tricep";
                mach.Machinename = "Tricep extension";
                mach.Machinedescription = "Machine to train tricep";

                return mach;
            }
            else { return null; }
        }

        public MachineDTO GetOneMachineByMachineName(string searchPhrase)
        {
            if (searchPhrase == "Tricep extension")
            {
                MachineDTO mach = new MachineDTO();
                mach.MachineId = 2;
                mach.Machinetype = "Tricep";
                mach.Machinename = "Tricep extension";
                mach.Machinedescription = "Machine to train tricep";

                return mach;
            }
            else { return null; }
        }
    }
}
