using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace DatabaseLayer
{
    public class TimeslotDAL : SqlConnect, ITimeslotContainer, ITimeslot
    {
        public TimeslotDAL()
        {
            Initialize();
        }

        /// <summary>
        /// Methode om een timeslot met bijbehoren aan te maken.
        /// </summary>
        /// <param name="dto">dto van timeslot die aangemaakt moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneTimeslot(TimeslotDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO TimeSlots (Day, Timeslot, MaxReservations) VALUES (@Day, @Timeslot, @MaxReservations)";

                cmd.Parameters.AddWithValue("@Day", dto.Day);
                cmd.Parameters.AddWithValue("@Timeslot", dto.Timeslot);
                cmd.Parameters.AddWithValue("@MaxReservations", dto.Maxreservations);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Methode om een timeslot met bijbehoren te verwijderen.
        /// </summary>
        /// <param name="id">Timeslotid van timeslot die aangemaakt moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneTimeslotById(int id)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM TimeSlots WHERE TimeslotID = @TimeslotID";
                cmd.Parameters.AddWithValue("@TimeslotID", id);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Methode om een timeslot met bijbehoren te verwijderen.
        /// </summary>
        /// <param name="day">dag van timeslot die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneTimeslotByDay(string day)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM TimeSlots WHERE Day = @Day";
                cmd.Parameters.AddWithValue("@Day", day);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Methode om een timeslot met bijbehoren te bewerken.
        /// </summary>
        /// <param name="dto">dto van timeslot die geupdate moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool EditOneTimeslotById(TimeslotDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "UPDATE TimeSlots SET Day = @Day, Timeslot = @Timeslot, MaxReservations = @MaxReservations WHERE TimeSlotID = @TimeSlotID";

                cmd.Parameters.AddWithValue("@TimeSlotID", dto.TimeslotID);
                cmd.Parameters.AddWithValue("@Day", dto.Day);
                cmd.Parameters.AddWithValue("@Timeslot", dto.Timeslot);
                cmd.Parameters.AddWithValue("@MaxReservations", dto.Maxreservations);

                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// list maken van alle reserveringen.
        /// </summary>
        /// <returns>List van alle timeslots</returns>
        public List<TimeslotDTO> GetAllTimeslots()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM TimeSlots";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<TimeslotDTO> listall = new List<TimeslotDTO>();

            while (rdr.Read())
            {
                TimeslotDTO timeslot = new TimeslotDTO()
                {
                    TimeslotID = rdr.GetInt32("TimeSlotID"),
                    Day = rdr.GetString("Day"),
                    Timeslot = rdr.GetString("Timeslot"),
                    Maxreservations = rdr.GetInt32("MaxReservations"),
                };
                listall.Add(timeslot);
            }
            CloseConnect();

            return listall;
        }

        /// <summary>
        /// Timeslot ophalen aan de hand van ingevulde TimeslotId
        /// </summary>
        /// <param name="id">Timeslotid van timeslot die opgehaald moet worden</param>
        /// <returns>List van timeslot</returns>
        public TimeslotDTO GetOneTimeslotById(int id)
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM TimeSlots WHERE TimeslotID = @TimeslotID";
            cmd.Parameters.AddWithValue("@TimeslotID", id);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            TimeslotDTO timeslot = new TimeslotDTO()
            {
                TimeslotID = rdr.GetInt32("TimeslotID"),
                Day = rdr.GetString("Day"),
                Timeslot = rdr.GetString("Timeslot"),
                Maxreservations = rdr.GetInt32("MaxReservations")
            };
            CloseConnect();
            return timeslot;
        }

        /// <summary>
        /// Timeslotlist list maken aan de hand van ingevulde dag.
        /// </summary>
        /// <param name="SearchPhrase">string van timeslots die opgehaald moeten worden</param>
        /// <returns>List van timeslot</returns>
        public List<TimeslotDTO> GetTimeslotsByDay(string SearchPhrase)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM TimeSlots WHERE Day = @Day";
                cmd.Parameters.AddWithValue("@Day", SearchPhrase);

                using SqlDataReader rdr = cmd.ExecuteReader();

                List<TimeslotDTO> listtimeslots = new List<TimeslotDTO>();

                while (rdr.Read())
                {
                    TimeslotDTO timeslots = new TimeslotDTO()
                    {
                        TimeslotID = rdr.GetInt32("TimeSlotID"),
                        Day = rdr.GetString("Day"),
                        Timeslot = rdr.GetString("Timeslot"),
                        Maxreservations = rdr.GetInt32("MaxReservations"),
                    };
                    listtimeslots.Add(timeslots);
                }
                CloseConnect();

                return listtimeslots;
            }
            else { return null; }
        }

        /// <summary>
        /// list maken van alle reserveringen met Day ("Distinct Day" om alle data uit column Day te filteren tot er 1 van elk overblijft).
        /// </summary>
        /// <returns>List van alle dagen</returns>
        public List<TimeslotDTO> GetAllDays()
        {
            OpenConnect();

            cmd.CommandText = "SELECT Distinct Day FROM TimeSlots";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<TimeslotDTO> listoneday = new List<TimeslotDTO>();

            while (rdr.Read())
            {
                TimeslotDTO listdays = new TimeslotDTO()
                {
                    Day = rdr.GetString("Day"),
                };
                listoneday.Add(listdays);
            }
            CloseConnect();

            return listoneday;
        }
    }
}
