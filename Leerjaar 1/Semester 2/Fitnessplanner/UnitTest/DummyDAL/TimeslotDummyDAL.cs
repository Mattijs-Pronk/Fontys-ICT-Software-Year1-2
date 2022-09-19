using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.DummyDAL
{
    public class TimeslotDummyDAL : ITimeslot, ITimeslotContainer
    {
        List<TimeslotDTO> list = new List<TimeslotDTO>();

        public bool AddOneTimeslot(TimeslotDTO dto)
        {
            try
            {
                if(dto.Day == "30-04-2022" && dto.Timeslot == "09:00" && dto.Maxreservations == 60) {
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
                return Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool DeleteOneTimeslotById(int id)
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

        public bool DeleteOneTimeslotByDay(string day)
        {
            try
            {
                if(day == "30-04-2022") { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public bool EditOneTimeslotById(TimeslotDTO dto)
        {
            try
            {
                if(dto.TimeslotID == 2 && dto.Day == "30-04-2022" && dto.Timeslot == "09:00" && dto.Maxreservations == 60) { 
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

        public List<TimeslotDTO> GetAllTimeslots()
        {
            TimeslotDTO dto = new TimeslotDTO();
            dto.TimeslotID = 2;
            dto.Day = "30-04-2022";
            dto.Timeslot = "09:00";
            dto.Maxreservations = 60;

            list.Add(dto);
            return list;
        }

        public TimeslotDTO GetOneTimeslotById(int id)
        {
            if(id == 2)
            {
                TimeslotDTO dto = new TimeslotDTO();
                dto.TimeslotID = 2;
                dto.Day = "30-04-2022";
                dto.Timeslot = "09:00";
                dto.Maxreservations = 60;

                return dto;
            }
            else { return null; }
        }

        public List<TimeslotDTO> GetAllDays()
        {
            TimeslotDTO dto = new TimeslotDTO();

            dto.TimeslotID = 2;
            dto.Day = "30-04-2022";
            dto.Timeslot = "09:00";
            dto.Maxreservations = 60;

            list.Add(dto);
            return list;
        }

        public List<TimeslotDTO> GetTimeslotsByDay(string SearchPhrase)
        {
            if(SearchPhrase == "30-04-2022") 
            {
                TimeslotDTO Dto = new TimeslotDTO();
                Dto.TimeslotID = 2;
                Dto.Day = "30-04-2022";
                Dto.Timeslot = "09:00";
                Dto.Maxreservations = 60;

                list.Add(Dto);
                return list;
            }
            else { return null; }
        }
    }
}
