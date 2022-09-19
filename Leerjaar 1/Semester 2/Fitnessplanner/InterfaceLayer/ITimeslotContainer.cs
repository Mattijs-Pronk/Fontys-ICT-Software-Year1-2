using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface ITimeslotContainer
    {
        public bool AddOneTimeslot(TimeslotDTO dto);

        public bool DeleteOneTimeslotById(int id);

        public bool DeleteOneTimeslotByDay(string day);

        public List<TimeslotDTO> GetAllTimeslots();

        public TimeslotDTO GetOneTimeslotById(int id);

        public List<TimeslotDTO> GetTimeslotsByDay(string SearchPhrase);

        public List<TimeslotDTO> GetAllDays();
    }
}
