using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class LoginDAL : SqlConnect, ILogin
    {
        public LoginDAL()
        {
            Initialize();
        }

        /// <summary>
        /// Methode die de database checkt of er een row is met het ingevulde email en wachtwoord.
        /// </summary>
        /// <param name="dto">dto van user die opgehaald moet worden</param>
        /// <returns>true als gelukt, false als niet gelukt</returns>
        public bool LoginUserExists(LoginDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = ("Select * from Users where Email = @Email AND Password = @Password");
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@Password", dto.Password);

            //reader om de row met matchend Email en password uit te lezen en te checken of het een user of een admin is.
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows) 
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
        /// Methode om gegevens van ingelogde user op tehalen
        /// </summary>
        /// <param name="dto">dto van user die opgehaald moet worden</param>
        /// <returns>alle gegevens van ingelogde user</returns>
        public LoginDTO LoginUser(LoginDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = ("Select * from Users where Email = @Email AND Password = @Password");
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@Password", dto.Password);


            //reader om de row met matchend Email en password uit te lezen en te checken of het een user of een admin is.
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            LoginDTO user = new LoginDTO()
            {
                //lokale variabele de voornaam, achternaam en email geven van ingelogd account.
                Id = Int32.Parse(rdr["UserID"].ToString()),
                Firstname = rdr["Firstname"].ToString(),
                Lastname = rdr["Lastname"].ToString(),
                Email = rdr["Adress"].ToString(),
                Adress = rdr["Email"].ToString(),
                Usertype = rdr["Usertype"].ToString(),
                SubscriptionStart = rdr["SubStart"].ToString(),
                SubscriptionEnd = rdr["SubEnd"].ToString(),

            };
            CloseConnect();
            return user;
        }
    }
}
