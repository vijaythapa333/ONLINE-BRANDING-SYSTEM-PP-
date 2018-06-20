using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnilneBrandingSystem.DAL
{
    public class pageRateDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["OnlineBrandingSystemConnection"].ConnectionString;
        #region Count Page Rating (Insert Update Page Rating)
        public bool CountPageRate(int id,int rate)
        {
            //Declare Return value and set its default value to false
            bool isSuccess = false;
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Writing T-SQl to Check if the page already exists or not
                string sql = string.Format("SELECT COUNT (*) FROM tbl_Page_Rate WHERE brand_id=" + id);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                {
                    //Brand Do not Exist (INSERT)
                    string sql2 = string.Format("INSERT INTO tbl_Page_Rate (brand_id,total_rating,no_of_rating) VALUES (" + id + ","+rate+",1)");
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);


                    //Execute Query
                    int rows = cmd2.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        //Successfully Inserted
                        isSuccess = true;
                    }
                    else
                    {
                        //FAiled to Insert
                        isSuccess = false;
                    }
                }
                else
                {
                    //Brand Exists (Update)
                    string sql2 = string.Format("UPDATE tbl_Page_Rate SET total_rating=total_rating+"+rate+ ",no_of_rating=no_of_rating+1 WHERE brand_id=" + id);
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);


                    //Execute Query
                    int rows = cmd2.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        //Successfully Inserted
                        isSuccess = true;
                    }
                    else
                    {
                        //FAiled to Insert
                        isSuccess = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Step : Close COnnection
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}