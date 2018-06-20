using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnilneBrandingSystem
{
    public partial class Masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CHeck if the use is logge in
            if(Session["login"]!=null)
            {
                lblLogoutMenu.Text = "Log Out";
                lblLoginmenu.Visible = false;
                lblLogoutMenu.Visible = true;
                lblBrandProfile.Text = "Profile";
                lblBrandProfile.Visible = true;
            }
            else
            {

                lblLoginmenu.Text = "Login ";// + Session["login"].ToString();
                lblLoginmenu.Visible = true;
                lblLogoutMenu.Visible = false;
                lblBrandProfile.Visible = false;
            }
        }
        
    }
}