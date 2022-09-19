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
    public class ProgramDAL : SqlConnect, IProgram, IProgramContainer
    {
        public ProgramDAL()
        {
            Initialize();
        }


        /// <summary>
        /// Methode om een programma toe te voegen
        /// </summary>
        /// <param name="dto">dto van programma die toegevoegd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneProgram(ProgramDTO dto)
        {
            if (OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "insert into Programs (ProgramName, ProgramDescription) values (@ProgramName, @ProgramDescription)";
                cmd.Parameters.AddWithValue("@ProgramName", dto.Programname);
                cmd.Parameters.AddWithValue("@ProgramDescription", dto.Programdescription);

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
        /// Methode om een programma te verwijderen
        /// </summary>
        /// <param name="id">ProgramId van programma die verwijdert moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneProgramById(int id)
        {
            if (OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM Programs WHERE ProgramID = @ProgramID";
                cmd.Parameters.AddWithValue("@ProgramID", id);

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
        /// Methode om enkel programma op te halen met programName
        /// </summary>
        /// <param name="searchPhrase">ProgramName van programma die opgehaald moet worden</param>
        /// <returns>object van programma</returns>
        public ProgramDTO GetOneProgramByName(string searchPhrase)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Programs WHERE ProgramName = @ProgramName";
            cmd.Parameters.AddWithValue("@ProgramName", searchPhrase);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            ProgramDTO program = new ProgramDTO()
            {
                ProgramId = rdr.GetInt32("ProgramID"),
                Programname = rdr.GetString("ProgramName"),
                Programdescription = rdr.GetString("ProgramDescription"),
            };
            CloseConnect();

            return program;
        }

        /// <summary>
        /// Methode om enkel programma op te halen met programId
        /// </summary>
        /// <param name="id">ProgramId van programma die opgehaald moet worden</param>
        /// <returns>object van programma</returns>
        public ProgramDTO GetOneProgramById(int id)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Programs WHERE ProgramID = @ProgramID";
            cmd.Parameters.AddWithValue("@ProgramID", id);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            ProgramDTO program = new ProgramDTO()
            {
                ProgramId = rdr.GetInt32("ProgramID"),
                Programname = rdr.GetString("ProgramName"),
                Programdescription = rdr.GetString("ProgramDescription"),
            };
            CloseConnect();

            return program;
        }

        /// <summary>
        /// Methode om een list met alle programma's op te halen
        /// </summary>
        /// <returns>list van alle programmas</returns>
        public List<ProgramDTO> GetAllPrograms()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Programs";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<ProgramDTO> listall = new List<ProgramDTO>();

            while (rdr.Read())
            {
                ProgramDTO programs = new ProgramDTO()
                {
                    ProgramId = rdr.GetInt32("ProgramID"),
                    Programname = rdr.GetString("ProgramName"),
                    Programdescription = rdr.GetString("ProgramDescription"),
                };
                listall.Add(programs);
            }
            CloseConnect();

            return listall;
        }
    }
}
