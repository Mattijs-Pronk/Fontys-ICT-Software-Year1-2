using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using Fitnessplanner2._0.DatabaseLayer;
using System.Data;

namespace Fitnessplanner2._0.LogicLayer
{
    public class AccountDAL : Connection
    {

        public AccountDAL()
        {
            Initialize();
        }

        public void Create(AccountDTO info)
        {
            OpenConnect();

            cmd.CommandText = "insert into tblUsers (Firstname, Lastname, Adress, Email, Password) values ('"+info.Firstname+"', '"+info.Lastname+"', '"+info.Adress+"', '"+info.Email+"', '"+info.Password+"')";

            cmd.ExecuteNonQuery();

            CloseConnect();
        }

        //public SqlDataReader Read()
        //{
        //    con.Open();

        //    cmd.CommandText = "Select * from tblUsers";
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    dgvUsers.DataSource = dt;
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    return reader;
        //}

        public void Update(AccountDTO info)
        {
            OpenConnect();

            cmd.CommandText = "Update tblUsers SET Firstname = '" + info.Firstname + "', Lastname = '" + info.Lastname + "', Adress = '" + info.Adress + "', Email = '" + info.Email + "', Password = '" + info.Password + "' WHERE ID = '" + info.ID + "'";

            cmd.ExecuteNonQuery();

            CloseConnect();
        }

        public void Delete()
        {

        }
    }
}
