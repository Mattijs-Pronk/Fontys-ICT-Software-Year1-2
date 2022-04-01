using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Configuration;

namespace Fitnessplanner2._0.DatabaseLayer
{
    public class AccountDTO
    {
        public string ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
