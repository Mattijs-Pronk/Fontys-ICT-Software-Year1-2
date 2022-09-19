using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.DummyDAL
{
    public class ProgramDummyDAL : IProgram, IProgramContainer
    {
        List<ProgramDTO> list = new List<ProgramDTO>();

        public bool AddOneProgram(ProgramDTO dto)
        {
            if(dto.Programname == "Tricep" && dto.Programdescription == "Mooi programmatje")
            {
                return true;
            }
            else { return false; }
        }

        public bool DeleteOneProgramById(int id)
        {
            if (id == 2)
            {
                return true;
            }
            else { return false; }
        }

        public List<ProgramDTO> GetAllPrograms()
        {
            ProgramDTO dto = new ProgramDTO();
            dto.ProgramId = 2;
            dto.Programname = "Tricep";
            dto.Programdescription = "Train tricep yes";

            list.Add(dto);
            return list;
        }

        public ProgramDTO GetOneProgramById(int id)
        {
            ProgramDTO dto = new ProgramDTO();
            dto.ProgramId = 2;
            dto.Programname = "Tricep";
            dto.Programdescription = "Train tricep yes";

            return dto;
        }

        public ProgramDTO GetOneProgramByName(string searchPhrase)
        {
            ProgramDTO dto = new ProgramDTO();
            dto.ProgramId = 2;
            dto.Programname = "Tricep";
            dto.Programdescription = "Train tricep yes";

            return dto;
        }
    }
}
