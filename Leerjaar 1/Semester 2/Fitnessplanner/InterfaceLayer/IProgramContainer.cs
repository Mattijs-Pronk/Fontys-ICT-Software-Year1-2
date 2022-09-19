using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IProgramContainer
    {
        public bool AddOneProgram(ProgramDTO dto);

        public bool DeleteOneProgramById(int id);

        public ProgramDTO GetOneProgramByName(string searchPhrase);

        public ProgramDTO GetOneProgramById(int id);

        public List<ProgramDTO> GetAllPrograms();
    }
}
