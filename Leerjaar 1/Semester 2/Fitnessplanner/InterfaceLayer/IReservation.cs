using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IReservation
    {
        public bool EditOneReservationById(ReservationDTO dto);

        public bool CheckReservationsById(ReservationDTO dto);

        public int CurrentReservations(int Id);
    }
}
