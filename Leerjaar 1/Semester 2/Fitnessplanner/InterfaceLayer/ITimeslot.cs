using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface ITimeslot
    {
        public bool EditOneTimeslotById(TimeslotDTO dto);

        //public int CurrentReservations(int Id);
    }
}
