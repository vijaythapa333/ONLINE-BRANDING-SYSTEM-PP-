using OnilneBrandingSystem.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnilneBrandingSystem.DAL
{
    public class GalleryDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["OnlineBrandingSystemConnection"].ConnectionString;

        #region Add Image
        public bool AddImage(Gallery gallery)
        {
            //set return value and set its default value to false
            bool isSuccess = false;
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Writing T-SQL
                string sql = "INSERT INTO tbl_Page_Gallery (brand_id,image_name,image_title) VALUES (@brand_id,@image_name,@image_title)";

                //Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass Value to Parameters
                cmd.Parameters.AddWithValue("@brand_id", gallery.brand_id);
                cmd.Parameters.AddWithValue("@image_name", gallery.image_name);
                cmd.Parameters.AddWithValue("@image_title", gallery.image_title);

                //open Connection
                conn.Open();

                //Execute Query
                int rows = cmd.ExecuteNonQuery();

                //If the brand is added then the rows will be greater than 1 and set the value of isSuccess to true else the rows will be less than 1 set isSuccess to false

                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Show all Image on Gallery
        public static List<Gallery> GetImages(int id)
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);


            //Should use in bottom (Avoiding Error)
            List<Gallery> list = new List<Gallery>();
            try
            {
                //Step 2: Writing T-SQL to Get recent Brands
                string sql = string.Format("SELECT * FROM tbl_Page_Gallery WHERE brand_id=" + id);

                //Step 3: Executing Query Here
                conn.Open();

                //Step 4: Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Step 5: Fetching Data

                while (reader.Read())
                {
                    Gallery gallery = new Gallery
                    {
                        image_id = Convert.ToInt32(reader["image_id"]),
                        brand_id = Convert.ToInt32(reader["brand_id"]),
                        image_name = Convert.ToString(reader["image_name"]),
                        image_title = Convert.ToString(reader["image_title"])
                    };
                    list.Add(gallery);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return list;
        }
        #endregion
    }
}