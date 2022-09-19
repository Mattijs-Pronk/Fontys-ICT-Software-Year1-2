using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using InterfaceLayer;

namespace BusinessLogicLayer
{
    public class TimeslotContainer
    {
        ITimeslotContainer ITimeslotContainer;

        public TimeslotContainer()
        {
        }

        public TimeslotContainer(ITimeslotContainer dal)
        {
            ITimeslotContainer = dal;
        }

        /// <summary>
        /// Methode om een timeslot met bijbehoren aan te maken.
        /// </summary>
        /// <param name="timeslot">object van timeslot die toegevoegt moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneTimeslot(Timeslot timeslot)
        {
            TimeslotDTO dto = timeslot.ToDTO();
            return ITimeslotContainer.AddOneTimeslot(dto);
        }

        /// <summary>
        /// Methode om een timeslot met bijbehoren te verwijderen.
        /// </summary>
        /// <param name="id">Timeslotid van timeslot die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneTimeslotById(int id)
        {
            return ITimeslotContainer.DeleteOneTimeslotById(id);
        }

        /// <summary>
        /// Methode om een timeslot met bijbehoren te verwijderen.
        /// </summary>
        /// <param name="day">dag van timeslot die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneTimeslotByDay(string day)
        {
            return ITimeslotContainer.DeleteOneTimeslotByDay(day);
        }

        /// <summary>
        /// Admin list maken van alle reserveringen met Id, Day, Timeslot, Currentreservations, maxreservations.
        /// </summary>
        /// <returns>list van alle timeslots</returns>
        public List<Timeslot> GetAllTimeslots()
        {
            //list aanmaken en vullen.
            List<Timeslot> alltimeslots = new List<Timeslot>();
            List<TimeslotDTO> listall = ITimeslotContainer.GetAllTimeslots();

            foreach (TimeslotDTO timeslots in listall)
            {
                Timeslot newtimeslot = new Timeslot(timeslots);
                alltimeslots.Add(newtimeslot);
            }
            return alltimeslots;
        }

        /// <summary>
        /// Timeslot ophalen aan de hand van ingevulde TimeslotId
        /// </summary>
        /// <param name="id">Timeslotid van timeslot die opgehaald moet worden</param>
        /// <returns>Object met gegevens van timeslot</returns>
        public Timeslot GetOneTimeslotById(int id)
        {
            return new Timeslot(ITimeslotContainer.GetOneTimeslotById(id));
        }

        /// <summary>
        /// Timeslotlist list maken aan de hand van ingevulde dag.
        /// </summary>
        /// <param name="SearchPhrase">dag van timeslots die opgehaald moeten worden</param>
        /// <returns>list van alle timeslots die bij day horen</returns>
        public List<Timeslot> GetTimeslotsByDay(string SearchPhrase)
        {
            //list aanmaken en vullen.
            List<Timeslot> timeslots = new List<Timeslot>();
            List<TimeslotDTO> listone = ITimeslotContainer.GetTimeslotsByDay(SearchPhrase);

            foreach (TimeslotDTO userdays in listone)
            {
                Timeslot newday = new Timeslot(userdays);
                timeslots.Add(newday);
            }
            return timeslots;
        }

        /// <summary>
        /// list maken van alle reserveringen met Day.
        /// </summary>
        /// <returns>list van days</returns>
        public List<Timeslot> GetAllDays()
        {
            //list aanmaken en vullen.
            List<Timeslot> days = new List<Timeslot>();
            List<TimeslotDTO> listone = ITimeslotContainer.GetAllDays();

            foreach (TimeslotDTO usertimeslots in listone)
            {
                Timeslot newtimeslot = new Timeslot(usertimeslots);
                days.Add(newtimeslot);
            }
            return days;
        }

        /// <summary>
        /// Methode om een niewe dag aan te maken en huidige dag te verwijderen
        /// </summary>
        public void NewDay()
        {
            var Maxreservations = 60;

            var timeslot1 = "09:00 - 10:00";
            var timeslot2 = "10:00 - 11:00";
            var timeslot3 = "11:00 - 12:00";
            var timeslot4 = "12:00 - 13:00";
            var timeslot5 = "13:00 - 14:00";
            var timeslot6 = "14:00 - 15:00";
            var timeslot7 = "15:00 - 16:00";
            var timeslot8 = "16:00 - 17:00";
            var timeslot9 = "17:00 - 18:00";
            var timeslot10 = "18:00 - 19:00";
            var timeslot11 = "19:00 - 20:00";
            var timeslot12 = "20:00 - 21:00";
            var timeslot13 = "21:00 - 22:00";

            DateTime dateNow = DateTime.Now.Date;
            DateTime date = dateNow.AddDays(7);

            Timeslot time1 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot1, Convert.ToInt32(Maxreservations));
            Timeslot time2 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot2, Convert.ToInt32(Maxreservations));
            Timeslot time3 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot3, Convert.ToInt32(Maxreservations));
            Timeslot time4 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot4, Convert.ToInt32(Maxreservations));
            Timeslot time5 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot5, Convert.ToInt32(Maxreservations));
            Timeslot time6 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot6, Convert.ToInt32(Maxreservations));
            Timeslot time7 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot7, Convert.ToInt32(Maxreservations));
            Timeslot time8 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot8, Convert.ToInt32(Maxreservations));
            Timeslot time9 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot9, Convert.ToInt32(Maxreservations));
            Timeslot time10 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot10, Convert.ToInt32(Maxreservations));
            Timeslot time11 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot11, Convert.ToInt32(Maxreservations));
            Timeslot time12 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot12, Convert.ToInt32(Maxreservations));
            Timeslot time13 = new Timeslot(date.ToString("dd-MM-yyyy"), timeslot13, Convert.ToInt32(Maxreservations));

            
            AddOneTimeslot(time1);
            AddOneTimeslot(time2);
            AddOneTimeslot(time3);
            AddOneTimeslot(time4);
            AddOneTimeslot(time5);
            AddOneTimeslot(time6);
            AddOneTimeslot(time7);
            AddOneTimeslot(time8);
            AddOneTimeslot(time9);
            AddOneTimeslot(time10);
            AddOneTimeslot(time11);
            AddOneTimeslot(time12);
            AddOneTimeslot(time13);
        }
    }
}
