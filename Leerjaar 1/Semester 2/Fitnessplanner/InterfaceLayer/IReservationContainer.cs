using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IReservationContainer
    {
        public bool AddOneReservation(ReservationDTO dto);

        public List<ReservationDTO> GetAllReservationsById(int id);

        public List<ReservationDTO> GetAllReservations();

        public ReservationDTO GetOneReservationsById(int id);

        public bool DeleteOneReservationByBookingId(int id);

        public bool DeleteAllReservationsByTimeslotId(int id);

        public bool DeleteAllReservationsByUserId(int id);
    }
}
