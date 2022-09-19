using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using InterfaceLayer;
using System.Data.Common;

namespace DatabaseLayer
{
    public class UserDAL : SqlConnect, IUserContainer, IUser
    {
        public bool usertype;

        public UserDAL()
        {
            Initialize();
        }

        /// <summary>
        /// Methode om een account met bijbehorende gegevens aan te maken.
        /// </summary>
        /// <param name="dto">dto van user die aangemaakt moet worden</param>
        /// <returns>true als gelukt, false als nie gelukt</returns>
        public bool AddOneUser(UserDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "insert into Users (Firstname, Lastname, Adress, Email, Password, Usertype, SubStart, SubEnd) values (@Firstname, @Lastname, @Adress, @Email, @Password, @Usertype, @SubStart, @SubEnd)";
                cmd.Parameters.AddWithValue("@Firstname", dto.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", dto.Lastname);
                cmd.Parameters.AddWithValue("@Adress", dto.Adress);
                cmd.Parameters.AddWithValue("@Email", dto.Email);
                cmd.Parameters.AddWithValue("@Password", dto.Password);
                cmd.Parameters.AddWithValue("@Usertype", dto.Usertype);
                cmd.Parameters.AddWithValue("@SubStart", dto.SubscriptionStart);
                cmd.Parameters.AddWithValue("@SubEnd", dto.SubscriptionEnd);

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
        /// methode om account met bijbehorende gegevens te verwijderen.
        /// </summary>
        /// <param name="id">Userid van user die verwijderd moet worden</param>
        /// <returns>true als gelukt, false als nie gelukt</returns>
        public bool DeleteOneUserById(int id)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM Users WHERE UserID = @UserID";
                cmd.Parameters.AddWithValue("@UserID", id);

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
        /// methode om uit te lezen of het account een admin of user is.
        /// </summary>
        /// <param name="id">Userid van user waarvan de permissions moeten worden gechecked</param>
        /// <returns>true als gelukt, false als nie gelukt</returns>
        public bool CheckForPermission(int id)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = ("SELECT * FROM Users WHERE UserID = @UserID");
            cmd.Parameters.AddWithValue("@UserID", id);

            //reader om de row met matchend ID uit te lezen en te checken of het een user of een admin is. Admin kan geen Admin verwijderen.
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            if (reader.GetString("Usertype") == "User")
            {
                CloseConnect();
                return true;
            }
            else
            {
                CloseConnect();
                return false;
            }
            
        }

        /// <summary>
        /// methode om account met bijbehorende gegevens te bewerken.
        /// </summary>
        /// <param name="dto">dto van user die geupdate moet worden</param>
        /// <returns>true als gelukt, false als nie gelukt</returns>
        public bool EditOneUserById(UserDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "UPDATE Users SET Firstname = @Firstname, Lastname = @Lastname, Adress = @Adress, Email = @Email, Password = @Password, Usertype = @Usertype, SubStart = @SubStart, SubEnd = @SubEnd WHERE UserID = @UserID";

                cmd.Parameters.AddWithValue("@UserID", dto.Id);
                cmd.Parameters.AddWithValue("@Firstname", dto.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", dto.Lastname);
                cmd.Parameters.AddWithValue("@Adress", dto.Adress);
                cmd.Parameters.AddWithValue("@Email", dto.Email);
                cmd.Parameters.AddWithValue("@Password", dto.Password);
                cmd.Parameters.AddWithValue("@Usertype", dto.Usertype);
                cmd.Parameters.AddWithValue("@SubStart", dto.SubscriptionStart);
                cmd.Parameters.AddWithValue("@SubEnd", dto.SubscriptionEnd);

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
        /// methode om te checken of email al bestaat in de database.
        /// </summary>
        /// <param name="email">email van user die moet checken of deze al bestaat</param>
        /// <returns>true als gelukt, false als nie gelukt</returns>
        public bool UserExists(string email)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Users WHERE Email = @Email";
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Dataset aanmaken en controlleren of de ingevulde email al bestaat.
            DataSet ds = new DataSet();
            da.Fill(ds);

            cmd.ExecuteNonQuery();

            CloseConnect();
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                ds.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// methode om account met subscriptie te bewerken.
        /// </summary>
        /// <param name="dto">dto van user die subscription moet updaten</param>
        /// <returns>true als gelukt, false als nie gelukt</returns>
        public bool ChangeSubscription(UserDTO dto)
        {
            if(OpenConnect())
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "UPDATE Users SET SubStart = @SubStart, SubEnd = @SubEnd WHERE UserID = @UserID";

                cmd.Parameters.AddWithValue("@UserID", dto.Id);
                cmd.Parameters.AddWithValue("@SubStart", dto.SubscriptionStart);
                cmd.Parameters.AddWithValue("@SubEnd", dto.SubscriptionEnd);

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
        /// list aanmaken die alle accounts met bijbehorende gegevens ophaalt.
        /// </summary>
        /// <returns>List van alle users</returns>
        public List<UserDTO> GetAllUsers()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Users";
            using SqlDataReader rdr = cmd.ExecuteReader();

            List<UserDTO> listall = new List<UserDTO>();

            while (rdr.Read())
            {
                UserDTO account = new UserDTO()
                {
                    Id = rdr.GetInt32("UserID"),
                    Firstname = rdr.GetString("Firstname"),
                    Lastname = rdr.GetString("Lastname"),
                    Adress = rdr.GetString("Adress"),
                    Email = rdr.GetString("Email"),
                    Password = rdr.GetString("Password"),
                    Usertype = rdr.GetString("Usertype"),
                    SubscriptionStart = rdr.GetString("SubStart"),
                    SubscriptionEnd = rdr.GetString("SubEnd"),
                };
                listall.Add(account);
            }
            CloseConnect();

            return listall;
        }

        /// <summary>
        /// object aanmaken die een enkel account met bijbehorende gegevens ophaalt door Id in te vullen.
        /// </summary>
        /// <param name="id">Userid van user die opgehaald moet worden</param>
        /// <returns>Object met user gegevens</returns>
        public UserDTO GetOneUserById(int id)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Users WHERE UserID = @UserID";
            cmd.Parameters.AddWithValue("@UserID", id);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            UserDTO account = new UserDTO()
            {
                Id = rdr.GetInt32("UserID"),
                Firstname = rdr.GetString("Firstname"),
                Lastname = rdr.GetString("Lastname"),
                Adress = rdr.GetString("Adress"),
                Email = rdr.GetString("Email"),
                Password = rdr.GetString("Password"),
                Usertype = rdr.GetString("Usertype"),
                SubscriptionStart = rdr.GetString("SubStart"),
                SubscriptionEnd = rdr.GetString("SubEnd"),
            };
            CloseConnect();
            return account;
        }

        /// <summary>
        /// object aanmaken die een enkel account met bijbehorende gegevens ophaalt door de email in te vullen.
        /// </summary>
        /// <param name="SearchPhrase">string om te checken of email al in de datbase staat</param>
        /// <returns></returns>
        public UserDTO GetOneUserByEmail(string SearchPhrase)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Users WHERE Email = @Email";
            cmd.Parameters.AddWithValue("@Email", SearchPhrase.ToLower());

            using SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows)
            {
                rdr.Read();
                UserDTO account = new UserDTO()
                {
                    Id = rdr.GetInt32("UserID"),
                    Firstname = rdr.GetString("Firstname"),
                    Lastname = rdr.GetString("Lastname"),
                    Adress = rdr.GetString("Adress"),
                    Email = rdr.GetString("Email"),
                    Password = rdr.GetString("Password"),
                    Usertype = rdr.GetString("Usertype"),
                    SubscriptionStart = rdr.GetString("SubStart"),
                    SubscriptionEnd = rdr.GetString("SubEnd"),
                };
                CloseConnect();
                return account;
            }
            else
            {
                return null;
            }
        }
    }
}
