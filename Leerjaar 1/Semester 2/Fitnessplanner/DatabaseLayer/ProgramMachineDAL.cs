using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class ProgramMachineDAL : SqlConnect, IProgramMachine, IProgramMachineContainer
    {
        public ProgramMachineDAL()
        {
            Initialize();
        }

        /// <summary>
        /// Methode om machine toe te voegen aan programma
        /// </summary>
        /// <param name="dto">dto van machine die toegevoegd moet worden aan programma</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddMachineToProgramById(ProgramMachineDTO dto)
        {
            if (OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO ProgramMachine (MachineID, ProgramID) VALUES (@MachineID, @ProgramID)";
                cmd.Parameters.AddWithValue("@MachineID", dto.MachineID);
                cmd.Parameters.AddWithValue("@ProgramID", dto.ProgramID);

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
        /// Methode om een programma te verwijderen van programma
        /// </summary>
        /// <param name="id">Programid van programma die verwijderd moet worden</param>
        /// <returns>true wanneer gelukt, false wanneer niet gelukt</returns>
        public bool DeleteOneProgramMachineByProgramId(int id)
        {
            if (OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM ProgramMachine WHERE ProgramID = @ProgramID";
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
        /// Methode om een machine te verwijderen van programma
        /// </summary>
        /// <param name="id">Programmachineid van programma die verwijderd moet worden</param>
        /// <returns>true wanneer gelukt, false wanneer niet gelukt</returns>
        public bool DeleteOneProgramMachineByProgramMachineId(int id)
        {
            if (OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM ProgramMachine WHERE ProgramMachineID = @ProgramMachineID";
                cmd.Parameters.AddWithValue("@ProgramMachineID", id);

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
        /// Methode om een enkel programma met bijbehorende machines op te halen
        /// </summary>
        /// <param name="dto">dto van programma die opgehaald moet worden</param>
        /// <returns>object van programma met machines</returns>
        public ProgramMachineDTO GetOneProgramMachines(ProgramMachineDTO dto)
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM ProgramMachine WHERE ProgramID = @ProgramID AND MachineID = @MachineID";
            cmd.Parameters.AddWithValue("@ProgramID", dto.ProgramID);
            cmd.Parameters.AddWithValue("@MachineID", dto.MachineID);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            ProgramMachineDTO program = new ProgramMachineDTO()
            {
                ProgramMachineID = rdr.GetInt32("ProgramMachineID"),
                ProgramID = rdr.GetInt32("ProgramID"),
                MachineID = rdr.GetInt32("MachineID")
            };

            CloseConnect();

            return program;
        }

        /// <summary>
        /// Methode om alle Programmas met bijbehorende machines op te halen.
        /// </summary>
        /// <param name="id">Programid van reservering die gechecked moet worden</param>
        /// <returns>list van alle programmas met bijbehorende machines</returns>
        public List<ProgramMachineDTO> GetAllProgramMachinesById(int id)
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM ProgramMachine INNER JOIN Machines ON ProgramMachine.MachineID = Machines.MachineID WHERE ProgramID = @ProgramID";
            cmd.Parameters.AddWithValue("@ProgramID", id);

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<ProgramMachineDTO> listall = new List<ProgramMachineDTO>();

            while (rdr.Read())
            {
                ProgramMachineDTO program = new ProgramMachineDTO()
                {
                    ProgramMachineID = rdr.GetInt32("ProgramMachineID"),
                };

                MachineDTO machine = new MachineDTO()
                {
                    Machinetype = rdr.GetString("MachineType"),
                    Machinename = rdr.GetString("MachineName"),
                    Machinedescription = rdr.GetString("MachineDescription"),
                };

                program.Machine = machine;
                listall.Add(program);
            }
            CloseConnect();

            return listall;
        }
    }
}
