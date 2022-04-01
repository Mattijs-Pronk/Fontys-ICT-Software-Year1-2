using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using Fitnessplanner2._0.DatabaseLayer;

namespace Fitnessplanner2._0.LogicLayer
{
    public class AccountContainer
    {
        //public static void Signup(AccountDTO info)
        //{
        //    AccountDAL.CreateAccount(info.Firstname, info.Lastname, info.Adress, info.Email, info.Password);
        //}



        //public void Createaccount()
        //{
        //    OpenConnect();

        //    cmd.CommandText = "insert into tblUsers values (@Firstname, @Lastname, @Adress, @Email, @Password, @Usertype)";

        //    cmd.Parameters.AddWithValue("@Firstname", accountDTO.Firstname);
        //    cmd.Parameters.AddWithValue("@Lastname", accountDTO.Lastname);
        //    cmd.Parameters.AddWithValue("@Adress", accountDTO.Adress);
        //    cmd.Parameters.AddWithValue("@Email", accountDTO.Email);
        //    cmd.Parameters.AddWithValue("@Password", accountDTO.Password);
        //    cmd.Parameters.AddWithValue("@Usertype", accountDTO.Usertype);

        //    cmd.ExecuteNonQuery();

        //    CloseConnect();
        //}

        //public void ReadAccount()
        //{
        //    OpenConnect();

        //    cmd.CommandText = "Select * from tblUsers where Email = @Email";
        //    cmd.Parameters.AddWithValue("@Email", accountDTO.Search);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);

        //    cmd.ExecuteNonQuery();

        //    CloseConnect();
        //}

        //public void UpdateAccount()
        //{
        //    OpenConnect();

        //    cmd.CommandText = "Update tblUsers set Firstname = @Firstname, Lastname = @Lastname, Adress = @Adress, Email = @Email, Password = @Password, Usertype = @Usertype where ID = @ID";

        //    cmd.Parameters.AddWithValue("@ID", accountDTO.ID);
        //    cmd.Parameters.AddWithValue("@Firstname", accountDTO.Firstname);
        //    cmd.Parameters.AddWithValue("@Lastname", accountDTO.Lastname);
        //    cmd.Parameters.AddWithValue("@Adress", accountDTO.Adress);
        //    cmd.Parameters.AddWithValue("@Email", accountDTO.Email);
        //    cmd.Parameters.AddWithValue("@Password", accountDTO.Password);
        //    cmd.Parameters.AddWithValue("@Usertype", accountDTO.Usertype);

        //    cmd.ExecuteNonQuery();

        //    CloseConnect();
        //}

        //public void DeleteAccount()
        //{
        //    OpenConnect();

        //    cmd.CommandText = "Delete tblUsers where ID = @ID";
        //    cmd.Parameters.AddWithValue("@ID", accountDTO.ID);

        //    cmd.ExecuteNonQuery();

        //    CloseConnect();
        //}
    }
}
