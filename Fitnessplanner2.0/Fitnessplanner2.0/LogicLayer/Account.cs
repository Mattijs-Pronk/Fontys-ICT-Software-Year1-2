using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Windows.Forms;
using Fitnessplanner2._0.DatabaseLayer;

namespace Fitnessplanner2._0.LogicLayer
{
    class Account
    {
        public string Firstname;
        public string Lastname;
        public string Adress;
        public string Email;
        public string Password;

        public Account(AccountDTO account)
        {
            this.Firstname = account.Firstname;
            this.Lastname = account.Lastname;
            this.Adress = account.Adress;
            this.Email = account.Email;
            this.Password = account.Password;
        }
    }
}
