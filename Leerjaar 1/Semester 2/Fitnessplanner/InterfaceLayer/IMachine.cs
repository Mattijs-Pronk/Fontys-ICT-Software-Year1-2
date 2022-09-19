using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IMachine
    {
        public bool EditOneMachineById(MachineDTO dto);
    }
}
