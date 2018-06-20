using OnilneBrandingSystem.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnilneBrandingSystem.DAL
{
    public class brandDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["OnlineBrandingSystemConnection"].ConnectionString;

        #region Add Brand
        public bool AddBrand(brandClass brand)
        {
            //set return value and set its default value to false
            bool isSuccess = false;
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Writing T-SQL
                string sql = "INSERT INTO tbl_Brands (brand_name,email,password,contact,description,location,keywords,category,addedDate,image) VALUES (@brand_name,@email,@password,@contact,@description,@location,@keywords,@category,@addedDate,@image)";

                //Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass Value to Parameters
                cmd.Parameters.AddWithValue("@brand_name", brand.brand_name);
                cmd.Parameters.AddWithValue("@email", brand.email);
                cmd.Parameters.AddWithValue("@password", brand.password);
                cmd.Parameters.AddWithValue("@contact", brand.contact);
                cmd.Parameters.AddWithValue("@description", brand.description);
                cmd.Parameters.AddWithValue("@location", brand.location);
                cmd.Parameters.AddWithValue("@keywords", brand.keywords);
                cmd.Parameters.AddWithValue("@category", brand.category);
                cmd.Parameters.AddWithValue("@image", brand.image);
                cmd.Parameters.AddWithValue("@addedDate", brand.addedDate);

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
        #region Get Brand By Keywords
        public static List<brandClass> GetBrandsBYKeywords(string keywords)
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);


            //Should use in bottom (Avoiding Error)
            List<brandClass> list = new List<brandClass>();
            try
            {
                //Step 2: Writing T-SQL to Get recent Brands
                string sql = string.Format("SELECT * FROM tbl_Brands WHERE brand_name LIKE '%"+keywords+ "%' OR location LIKE '%" + keywords + "%'");

                //Step 3: Executing Query Here
                conn.Open();

                //Step 4: Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Step 5: Fetching Data

                while (reader.Read())
                {
                    brandClass brand = new brandClass
                    {
                        brand_id = Convert.ToInt32(reader["brand_id"]),
                        brand_name = Convert.ToString(reader["brand_name"]),
                        addedDate = Convert.ToDateTime(reader["addedDate"]),
                        image = Convert.ToString(reader["image"])
                    };
                    list.Add(brand);
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

        #region Get Latest Brand (By Added Date)
        public static List<brandClass> GetNewBrands()
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);


            //Should use in bottom (Avoiding Error)
            List<brandClass> list = new List<brandClass>();
            try
            {
                //Step 2: Writing T-SQL to Get recent Brands
                string sql = string.Format("SELECT * FROM tbl_Brands ORDER BY addedDate DESC");

                //Step 3: Executing Query Here
                conn.Open();

                //Step 4: Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Step 5: Fetching Data

                while (reader.Read())
                {
                    brandClass brand = new brandClass
                    {
                        brand_id = Convert.ToInt32(reader["brand_id"]),
                        brand_name = Convert.ToString(reader["brand_name"]),
                        addedDate = Convert.ToDateTime(reader["addedDate"]),
                        image=Convert.ToString(reader["image"])
                    };
                    list.Add(brand);
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

        #region Get Brand Details By ID
        public static List<brandClass> GetBrandDetails(int id)
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);


            //Should use in bottom (Avoiding Error)
            List<brandClass> list = new List<brandClass>();
            try
            {
                //Step 2: Writing T-SQL to Get recent Brands
                string sql = string.Format("SELECT * FROM tbl_Brands WHERE brand_id=" + id);

                //Step 3: Executing Query Here
                conn.Open();

                //Step 4: Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Step 5: Fetching Data

                while (reader.Read())
                {
                    brandClass brand = new brandClass
                    {
                        brand_id = Convert.ToInt32(reader["brand_id"]),
                        brand_name = Convert.ToString(reader["brand_name"]),
                        email = Convert.ToString(reader["email"]),
                        password = Convert.ToString(reader["password"]),
                        contact = Convert.ToString(reader["contact"]),
                        description = Convert.ToString(reader["description"]),
                        location = Convert.ToString(reader["location"]),
                        keywords = Convert.ToString(reader["keywords"]),
                        category = Convert.ToString(reader["category"]),
                        image = Convert.ToString(reader["image"]),
                        addedDate = Convert.ToDateTime(reader["addedDate"])
                    };
                    list.Add(brand);
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
        #region Get Brands by Category
        public static List<brandClass> GetBrandsBYCategory(string category)
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);


            //Should use in bottom (Avoiding Error)
            List<brandClass> list = new List<brandClass>();
            try
            {
                //Step 2: Writing T-SQL to Get recent Brands
                string sql = string.Format("SELECT * FROM tbl_Brands WHERE category='"+category+"'");

                //Step 3: Executing Query Here
                conn.Open();

                //Step 4: Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Step 5: Fetching Data

                while (reader.Read())
                {
                    brandClass brand = new brandClass
                    {
                        brand_id = Convert.ToInt32(reader["brand_id"]),
                        brand_name = Convert.ToString(reader["brand_name"]),
                        addedDate = Convert.ToDateTime(reader["addedDate"]),
                        category=Convert.ToString(reader["category"])
                    };
                    list.Add(brand);
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
        #region Get Brand Details By Email
        public static List<brandClass> GetBrandDetailsByEmail(string email)
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);


            //Should use in bottom (Avoiding Error)
            List<brandClass> list = new List<brandClass>();
            try
            {
                //Step 2: Writing T-SQL to Get recent Brands
                string sql = string.Format("SELECT * FROM tbl_Brands WHERE email='" + email+"'");

                //Step 3: Executing Query Here
                conn.Open();

                //Step 4: Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Step 5: Fetching Data

                while (reader.Read())
                {
                    brandClass brand = new brandClass
                    {
                        brand_id = Convert.ToInt32(reader["brand_id"]),
                        brand_name = Convert.ToString(reader["brand_name"]),
                        email = Convert.ToString(reader["email"]),
                        password = Convert.ToString(reader["password"]),
                        contact = Convert.ToString(reader["contact"]),
                        description = Convert.ToString(reader["description"]),
                        location = Convert.ToString(reader["location"]),
                        keywords = Convert.ToString(reader["keywords"]),
                        category = Convert.ToString(reader["category"]),
                        image = Convert.ToString(reader["image"]),
                        addedDate = Convert.ToDateTime(reader["addedDate"])
                    };
                    list.Add(brand);
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
        #region Get Brands Detail according to brand_id from pageview table (realted to above)
        public static List<brandClass> GetBrandsWithMaxmHits()
        {
            //sTep 1: DAtabase Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Step 2: 
            List<brandClass> brands = new List<brandClass>();
            List<pageViewClass> pages = pageViewDAL.GetBrandsIdWithMaxhit();
            brandClass brand = new brandClass();
            List<brandClass> brandList = new List<brandClass>();


            try
            {
                //Open Database Connection
                conn.Open();

                if (pages.Count == 0)
                {
                    //No Brands according to Pageviews Found

                }
                else
                {
                    //int a = 1;
                    foreach (pageViewClass page in pages)//Contains Multiple Brand ID
                    {
                        int brand_id = page.brand_id;
                        //Writing T-SQL to get all the brand details
                        string sql = string.Format("SELECT * FROM tbl_Brands WHERE brand_id=" + brand_id); //REturns SIngle Brand


                        //Create SqlCommand using Sql and conn
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        //Execute Query
                        SqlDataReader reader = cmd.ExecuteReader();

                        //Fetching data Acording to the query
                        while (reader.Read())
                        {
                            //brandClass brand = new brandClass
                            brandClass n = new brandClass()
                            {
                                brand_id = Convert.ToInt32(reader["brand_id"]),
                                brand_name = Convert.ToString(reader["brand_name"]),
                                addedDate = Convert.ToDateTime(reader["addedDate"]),
                                image=Convert.ToString(reader["image"])
                            };
                            //brand.brand_id = Convert.ToInt32(reader["brand_id"]);
                            //brand.brand_name = Convert.ToString(reader["brand_name"]);
                            //brand.addedDate = Convert.ToDateTime(reader["addedDate"]);

                            brandList.Add(n);
                            //brands.Add(brand);
                        }
                        //brandList.Add(brand);
                        brands.Add(brand);
                        reader.Close();
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return brandList;
        }
        #endregion
    }
}