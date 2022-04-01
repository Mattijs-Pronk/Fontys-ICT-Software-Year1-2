using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Fitnessplanner2._0.LogicLayer;
using Fitnessplanner2._0.DatabaseLayer;

namespace Fitnessplanner2._0
{
    public partial class Form1 : Form
    {
        private string ID;
        private string Firstname;
        private string Lastname;
        private string Adress;
        private string Email;
        private string Password;

        public Form1()
        {
            InitializeComponent();

            Readall();
        }

        AccountDTO info = new AccountDTO();
        static AccountDAL account = new AccountDAL();
        //SqlDataReader reader = account.Read();

        private void btCreateaccount_Click(object sender, EventArgs e)
        {
            CheckTextBox();

            account.Create(info);

            Readall();
        }

        private void CheckTextBox()
        {
            ID = tbID.Text;
            Firstname = tbFirstname.Text;
            Lastname = tbLastname.Text;
            Adress = tbAdress.Text;
            Email = tbEmail.Text;
            Password = tbPassword.Text;

            info.ID = ID;
            info.Firstname = Firstname;
            info.Lastname = Lastname;
            info.Adress = Adress;
            info.Email = Email;
            info.Password = Password;
        }

        private void btViewall_Click(object sender, EventArgs e)
        {
            Update();

            Readall();
        }

        private void Readall()
        {
            account.OpenConnect();

            account.cmd.CommandText = "Select * from tblUsers";
            SqlDataAdapter da = new SqlDataAdapter(account.cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvUsers.DataSource = dt;

            account.CloseConnect();
        }
        //private void Readall()
        //{
        //    if(reader.HasRows)
        //    {
        //        while(reader.Read())
        //        {
        //            object[] obj = { reader["ID"], reader["Firstname"].ToString(), reader["Lastname"].ToString(), reader["Adress"].ToString(), reader["Email"].ToString(), reader["Password"].ToString(), };
        //            dgvUsers.Rows.Add(obj);
        //        }
        //    }

        //    else
        //    {
        //        MessageBox.Show("No Accounts to display");
        //    }
        //}

        private void btUpdateaccount_Click(object sender, EventArgs e)
        {
            CheckTextBox();

            account.Update(info);

            Readall();
        }
    }
}
