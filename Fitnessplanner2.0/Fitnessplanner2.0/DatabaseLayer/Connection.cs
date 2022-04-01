using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Configuration;
using Dapper;

namespace Fitnessplanner2._0.DatabaseLayer
{
    public class Connection
    {
        internal SqlCommand cmd;
        internal SqlConnection con;

        public void Initialize()
        {
            string connectionString = ("Data Source=DESKTOP-T5DHN9T\\SQLEXPRESS;Initial Catalog = fitnessplanner3.0; Integrated Security = True");
            con = new SqlConnection(connectionString); ;
            cmd = con.CreateCommand();
        }

        public bool OpenConnect()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool CloseConnect()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //public static string GetConnectionString(string connectionName = "Data Source=DESKTOP-T5DHN9T\\SQLEXPRESS;Initial Catalog = fitnessplanner3.0; Integrated Security = True")
        //{
        //    return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        //}

        //public static List<T> LoadData <T> (string sql)
        //{
        //    using(IDbConnection con = new SqlConnection(GetConnectionString()))
        //    {
        //        return con.Query<T>(sql).ToList();
        //    }
        //}

        //public static int SaveData<T>(string sql, T data)
        //{
        //    using (IDbConnection con = new SqlConnection(GetConnectionString()))
        //    {
        //        return con.Execute(sql, data);
        //    }
        //}

        //internal SqlCommand cmd;
        //internal SqlConnection conn;
    }
}
