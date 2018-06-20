using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnilneBrandingSystem.Classes
{
    public class connectionClass
    {
        //Step 1: Database Connection
        private static SqlConnection conn;
        private static SqlCommand command;

        #region Database Connection
        static connectionClass()
        {
            //Connecting to Database
            string connectionString = ConfigurationManager.ConnectionStrings["OnlineBrandingSystemConnection"].ToString();
            conn = new SqlConnection(connectionString);
            command = new SqlCommand("", conn);
        }
        #endregion
        #region Add Brand
        public static void AddBrand(brandClass brand)
        {
            
        }
        #endregion
    }
}