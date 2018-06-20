using OnilneBrandingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnilneBrandingSystem.pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            LoginDAL dal = new LoginDAL();
            bool success = dal.brandLogin(email, password);
            if(success==true)
            {
                //Login SUcces
                Session["login"] = email;
                Session["welcome"] = "Welcome to the admin panel";
                Response.Redirect("~/Pages/brandProfile.aspx");
            }
            else
            {
                //Login Failed
                Response.Redirect("~/Pages/Login.aspx");
            }
        }
    }
}