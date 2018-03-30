using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using DataLayer;
using System.Data.SqlClient;
using System.Data;
namespace BuisnessLayer
{
    public class UserADO
    {
        DBConnection ob = new DBConnection();
        public int RegisterUser(User u)
        {
           
            SqlConnection con=ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Ar_User values(@userid,@name,@pass,@ccno,@cctype,@ccmonth,@ccyear,@age)";
            cmd.Parameters.AddWithValue("@userid", u.UserID);
            cmd.Parameters.AddWithValue("@name", u.Name);
            cmd.Parameters.AddWithValue("@pass", u.Password);
            cmd.Parameters.AddWithValue("@ccno", u.CreditcardNo);
            cmd.Parameters.AddWithValue("@cctype", u.CreditcardType);
            cmd.Parameters.AddWithValue("@ccmonth",u.CcExpiryMonth);
            cmd.Parameters.AddWithValue("@ccyear", u.CcExpiryYear);
            cmd.Parameters.AddWithValue("@age", u.Age);
            cmd.Connection = con;
            int res=cmd.ExecuteNonQuery();
            ob.CloseConnection();
            return res;
        }
        public bool ValidateUser(string userId, string passwd)
        {
            SqlConnection con = ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select User_Id,Passwd from AR_User";
            cmd.Connection = con;
            SqlDataReader dr= cmd.ExecuteReader();
            bool flag=false;
            while (dr.Read())
            {
                if((userId==dr[0].ToString())&&(passwd==dr[1].ToString()))
                    flag=true;

            }
            ob.CloseConnection();
            return flag;
 
        }
    }
}
