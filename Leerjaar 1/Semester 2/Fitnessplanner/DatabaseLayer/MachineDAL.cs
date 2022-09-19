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
    public class MachineDAL : SqlConnect, IMachineContainer, IMachine
    {
        public MachineDAL()
        {
            Initialize();
        }

        /// <summary>
        /// Methode om een machine met bijbehorende gegevens aan te maken.
        /// </summary>
        /// <param name="dto">dto van machine die aangemaakt moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool AddOneMachine(MachineDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO Machines (MachineType, MachineName, MachineDescription) VALUES (@MachineType, @MachineName, @MachineDescription)";
                cmd.Parameters.AddWithValue("@MachineType", dto.Machinetype);
                cmd.Parameters.AddWithValue("@MachineName", dto.Machinename);
                cmd.Parameters.AddWithValue("@MachineDescription", dto.Machinedescription);

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
        /// methode om machine met bijbehorende gegevens te bewerken.
        /// </summary>
        /// <param name="dto">dto van machine die aangepast moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool EditOneMachineById(MachineDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "UPDATE Machines SET MachineType = @MachineType, MachineName = @MachineName, MachineDescription = @MachineDescription WHERE MachineID = @MachineID";

                cmd.Parameters.AddWithValue("@MachineID", dto.MachineId);
                cmd.Parameters.AddWithValue("@MachineType", dto.Machinetype);
                cmd.Parameters.AddWithValue("@MachineName", dto.Machinename);
                cmd.Parameters.AddWithValue("@MachineDescription", dto.Machinedescription);

                cmd.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// methode om machine met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Machineid van machine die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool DeleteOneMachineById(int id)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM Machines WHERE MachineID = @MachineID";
                cmd.Parameters.AddWithValue("@MachineID", id);

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
        /// Methode om een machine op te halen met het Id.
        /// </summary>
        /// <param name="id">Machineid van machine die opgehaald moet worden</param>
        /// <returns>object van machine</returns>
        public MachineDTO GetOneMachineById(int id)
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Machines WHERE MachineID = @MachineID";
            cmd.Parameters.AddWithValue("@MachineID", id);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            MachineDTO Machines = new MachineDTO()
            {
                MachineId = rdr.GetInt32("MachineID"),
                Machinetype = rdr.GetString("MachineType"),
                Machinename = rdr.GetString("MachineName"),
                Machinedescription = rdr.GetString("MachineDescription"),
            };

            CloseConnect();

            return Machines;
        }

        /// <summary>
        /// Methode om machine op te halen met machinename
        /// </summary>
        /// <param name="searchPhrase">MachineName van machine die opgehaald moet worden</param>
        /// <returns>object van machine</returns>
        public MachineDTO GetOneMachineByMachineName(string searchPhrase)
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Machines WHERE MachineName = @MachineName";
            cmd.Parameters.AddWithValue("@MachineName", searchPhrase);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            MachineDTO Machine = new MachineDTO()
            {
                MachineId = rdr.GetInt32("MachineID"),
                Machinetype = rdr.GetString("MachineType"),
                Machinename = rdr.GetString("MachineName"),
                Machinedescription = rdr.GetString("MachineDescription"),
            };

            CloseConnect();

            return Machine;
        }

        /// <summary>
        /// Methode om alle machines met ingevulde type op te halen
        /// </summary>
        /// <param name="SearchPhrase">machinetype van machines die opgehaald moeten worden</param>
        /// <returns>list met machines</returns>
        public List<MachineDTO> GetAllMachinesByMachineType(string SearchPhrase)
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Machines WHERE MachineType = @MachineType";
            cmd.Parameters.AddWithValue("@MachineType", SearchPhrase);

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<MachineDTO> listmachines = new List<MachineDTO>();

            while(rdr.Read())
            {
                MachineDTO machine = new MachineDTO()
                {
                    MachineId = rdr.GetInt32("MachineID"),
                    Machinetype = rdr.GetString("MachineType"),
                    Machinename = rdr.GetString("MachineName"),
                    Machinedescription = rdr.GetString("MachineDescription"),
                };
                listmachines.Add(machine);
            }
            CloseConnect();

            return listmachines;
        }

        /// <summary>
        /// list om alle machines met bijbehoren weer te geven.
        /// </summary>
        /// <returns>list van alle machines</returns>
        public List<MachineDTO> GetAllMachines()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Machines";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<MachineDTO> listmachines = new List<MachineDTO>();

            while (rdr.Read())
            {
                MachineDTO machine = new MachineDTO()
                {
                    MachineId = rdr.GetInt32("MachineID"),
                    Machinetype = rdr.GetString("MachineType"),
                    Machinename = rdr.GetString("MachineName"),
                    Machinedescription = rdr.GetString("MachineDescription"),
                };
                listmachines.Add(machine);
            }
            CloseConnect();

            return listmachines;
        }
    }
}
