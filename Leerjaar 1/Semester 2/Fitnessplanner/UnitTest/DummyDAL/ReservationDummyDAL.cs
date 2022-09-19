using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.DummyDAL
{
    public class ReservationDummyDAL : IReservation, IReservationContainer
    {
        List<ReservationDTO> list = new List<ReservationDTO>();

        public bool AddOneReservation(ReservationDTO dto)
        {
            try
            {
                if(dto.UserID == 5 && dto.ProgramID == 4 && dto.TimeslotID == 3) {
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

        public bool CheckReservationsById(ReservationDTO dto)
        {
            try
            {
                if(dto.UserID == 5 && dto.TimeslotID == 2) {
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

        public int CurrentReservations(int Id)
        {
            try
            {
                if(Id == 5) { return 9; }
                else { return 0; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool DeleteAllReservationsByTimeslotId(int id)
        {
            try
            {
                if (id == 2) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool DeleteAllReservationsByUserId(int id)
        {
            try
            {
                if (id == 2) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool DeleteOneReservationByBookingId(int id)
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

        public bool EditOneReservationById(ReservationDTO dto)
        {
            try
            {
                if(dto.UserID == 5 && dto.TimeslotID == 2) {
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

        public List<ReservationDTO> GetAllReservations()
        {
            ReservationDTO dto = new ReservationDTO();
            dto.BookingID = 2;
            dto.TimeslotID = 3;
            dto.ProgramID = 4;
            dto.UserID = 5;

            list.Add(dto);
            return list;
        }

        public List<ReservationDTO> GetAllReservationsById(int id)
        {
            if(id == 2)
            {
                ReservationDTO dto = new ReservationDTO();
                dto.BookingID = 2;
                dto.TimeslotID = 3;
                dto.ProgramID = 4;
                dto.UserID = 5;

                list.Add(dto);
                return list;
            }
            else { return null; }
        }

        public ReservationDTO GetOneReservationsById(int id)
        {
            if (id == 2)
            {
                ReservationDTO dto = new ReservationDTO();
                dto.BookingID = 2;
                dto.TimeslotID = 2;
                dto.ProgramID = 2;
                dto.UserID = 2;

                return dto;
            }
            else { return null; }
        }
    }
}
