using OnilneBrandingSystem.Classes;
using OnilneBrandingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnilneBrandingSystem.pages
{
    public partial class brandDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
            //Count Page Views
            int id = Convert.ToInt32(Request.QueryString["id"]);//Getting Value from URL
            pageViewDAL pageHits = new pageViewDAL();
            bool check=pageHits.CountPageViews(id);
            //if(check==true)
            //{
            //    lblCheck.Text = "Updated";
            //}
            //else
            //{
            //    lblCheck.Text = "Inserted";
            //}
            //Viewing Images on GAllery
            GetImages();
        }
        private void FillPage()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);//Getting Value from URL

            List<brandClass> brandDetail = brandDAL.GetBrandDetails(id);
            if(brandDetail.Count==1)
            {
                StringBuilder sb = new StringBuilder();
                foreach(brandClass brand in brandDetail)
                {
                    sb.Append(string.Format(@"
                            <h2>{0}</h2>
                <br />
                <span class='cover'>
                <img src = '../images/brands/{6}' height='300px' alt= '{0}' title = '{0}' runat = 'server' />
                </ span >


                <div class='about'>
                    <div class='quotes'>
                        &ldquo; ALL OR NOTHING &rdquo;
                    </div>
                    <p>
                        {3}
                    </p>
                    
                </div>

                <h4>Category: {5}</h4>
                <h4>Location: {4}</h4>
                <h4>Email: {1}</h4>
                <h4>Contact: {2}</h4>
                <hr />
                <br />

               
                    ", brand.brand_name,brand.email,brand.contact,brand.description,brand.location,brand.category,brand.image));
                    lblTest.Text = sb.ToString();
                }
            }
            else
            {
                lblTest.Text = "Invalid Brand ID";
                //Response.Redirect("Home.aspx");
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            getIP IP = new getIP();
            string user=IP.GetUserIP(); //To validate user
            int pageid = Convert.ToInt32(Request.QueryString["id"]);//Getting Value from URL
            pageRateDAL pageHits = new pageRateDAL();
            //Get Values from radio button
            int rate = 0;
            if(RadioButton1.Checked)
            {
                rate = Convert.ToInt32(RadioButton1.Text);
            }
            else if(RadioButton2.Checked)
            {
                rate = Convert.ToInt32(RadioButton2.Text);
            }
            else if (RadioButton3.Checked)
            {
                rate = Convert.ToInt32(RadioButton3.Text);
            }
            else if (RadioButton4.Checked)
            {
                rate = Convert.ToInt32(RadioButton4.Text);
            }
            else if (RadioButton5.Checked)
            {
                rate = Convert.ToInt32(RadioButton5.Text);
            }
            else
            {
                rate = 0;
            }
            bool check = pageHits.CountPageRate(pageid,rate);
            if(check==true)
            {
                lblMessage.Text = "Success";
            }
            else
            {
                lblMessage.Text = "Failed";
            }
        }
        private void GetImages()
        {
            int brand_id = Convert.ToInt32(Request.QueryString["id"]); ;
            
            //Getting Images Based on This Brand ID
            List<Gallery> images = GalleryDAL.GetImages(brand_id);
            if (images.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Gallery image in images)
                {

                    sb.Append(string.Format(@"
                    <a class='group' rel='gallery' href='../images/gallery/{2}' title='{0}'>
                        <div class='image'>
                            <img src = '../images/gallery/{2}' runat='server' alt='Gallery Image Here' title='{3}' height='300px' />
                        </div>
                    </a>     

                    ", image.image_id, image.brand_id, image.image_name, image.image_title));
                    lblGallery.Text = sb.ToString();
                }
            }
            else
            {
                lblGallery.Text = "No Image Added";
            }
        }
    }
}