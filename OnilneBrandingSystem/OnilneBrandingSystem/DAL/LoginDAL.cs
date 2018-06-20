using OnilneBrandingSystem.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnilneBrandingSystem.DAL
{
    public class LoginDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["OnlineBrandingSystemConnection"].ConnectionString;

        public bool brandLogin(string email,string password)
        {
            //SEt a default return value and its default value to false
            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Writing T SQL
                string sql = "SELECT * FROM tbl_Brands WHERE email=@email and password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}