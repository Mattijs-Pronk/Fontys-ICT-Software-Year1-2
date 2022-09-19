using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public class ReservationDTO
    {
        public int BookingID;
        public int UserID;
        public int TimeslotID;
        public int ProgramID;
        public TimeslotDTO Timeslot;
        public ProgramDTO Program;
    }
}
