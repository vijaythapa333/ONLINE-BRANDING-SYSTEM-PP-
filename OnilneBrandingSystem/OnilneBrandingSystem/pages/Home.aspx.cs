using OnilneBrandingSystem.Classes;
using OnilneBrandingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnilneBrandingSystem.pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////GetUser_IP();
            //getIP IP = new getIP();
            //string user=IP.GetUserIP();
            //lblTest.Text = "Your IP is "+user;

            RecentBrands();
            PopularBrands();
        }

        private void RecentBrands()
        {
            List<brandClass> brandList = brandDAL.GetNewBrands();
            if (brandList.Count == 0)
            {
                lblNewBrands.Text = "No Brands Found";
            }
            StringBuilder sb = new StringBuilder();

            foreach (brandClass brand in brandList)
            {
                sb.Append(string.Format(@"
                        <a href='brandDetail.aspx?id={0}'>
                    <div class='brand-box'>
                        <img src = '../images/brands/{3}' runat='server' />
                        <h3>{1}</h3>
                        Added Date: {2}
                    </div>
                </a>
                    
                ", brand.brand_id, brand.brand_name, brand.addedDate,brand.image));
                lblNewBrands.Text = sb.ToString();
            }
        }

        private void PopularBrands()
        {
            List<brandClass> brandList = brandDAL.GetBrandsWithMaxmHits();
            if (brandList.Count == 0)
            {
                lblTest.Text = "No Brands Found";
            }
            StringBuilder sb = new StringBuilder();

            foreach (brandClass brand in brandList)
            {
                sb.Append(string.Format(@"
                        <a href='brandDetail.aspx?id={0}'>
                    <div class='brand-box'>
                        <img src = '../images/brands/{3}' runat='server' />
                        <h3>{1}</h3>
                        Added Date: {2}
                    </div>
                </a>
                    
                ", brand.brand_id, brand.brand_name, brand.addedDate,brand.image));
                lblPopularBrands.Text = sb.ToString();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            Response.Redirect("~/Pages/Search.aspx?keywords="+keywords);
        }
    }
}