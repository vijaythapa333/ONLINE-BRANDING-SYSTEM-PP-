using OnilneBrandingSystem.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnilneBrandingSystem.DAL
{
    public class pageViewDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["OnlineBrandingSystemConnection"].ConnectionString;

        #region Count Page Views (Insert Update Page Views)
        public bool CountPageViews(int id)
        {
            //Declare Return value and set its default value to false
            bool isSuccess = false;
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Writing T-SQl to Check if the page already exists or not
                string sql = string.Format("SELECT COUNT (*) FROM tbl_Page_Views WHERE brand_id="+id);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if(count==0)
                {
                    //Brand Do not Exist (INSERT)
                    string sql2 = string.Format("INSERT INTO tbl_Page_Views (brand_id,hits) VALUES ("+id+",1)");
                    SqlCommand cmd2 = new SqlCommand(sql2,conn);
                    

                    //Execute Query
                    int rows = cmd2.ExecuteNonQuery();
                    if(rows>0)
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
                    string sql2 = string.Format("UPDATE tbl_Page_Views SET hits=hits+1 WHERE brand_id="+id);
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
            catch(Exception ex)
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

        #region Get All Brands with Maxm Page Views
        public static List<pageViewClass> GetBrandsIdWithMaxhit()
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Step 2: 
            List<pageViewClass> pages = new List<pageViewClass>();

            try
            {
                //step 2: Writing T-SQL to get brands with maxm hits
                string sql = string.Format("SELECT * FROM tbl_Page_Views ORDER BY hits DESC");

                //Step 3: Open Database Connection
                conn.Open();

                //STep 4: Create SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Step 5: Fetching Data
                while(reader.Read())
                {
                    pageViewClass page = new pageViewClass
                    {
                        page_view_id = Convert.ToInt32(reader["page_view_id"]),
                        brand_id=Convert.ToInt32(reader["brand_id"]),
                        hits=Convert.ToInt32(reader["hits"])
                    };
                    pages.Add(page);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Step : 
                conn.Close();
            }

            return pages;
        }
        #endregion

        
    }
}