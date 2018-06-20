using OnilneBrandingSystem.Classes;
using OnilneBrandingSystem.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnilneBrandingSystem.pages
{
    public partial class brandProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["login"]==null)
            {
                Response.Redirect("~/Pages/Login.aspx");
            }
            FillPage();
            GetImages();
            
        }
        private void FillPage()
        {
            if(Session["login"]!=null)
            {
                string email = Session["login"].ToString();
                List<brandClass> brandDetail = brandDAL.GetBrandDetailsByEmail(email);
                if(brandDetail.Count==1)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach(brandClass brand in brandDetail)
                    {
                        
                        sb.Append(string.Format(@"
               
                <table style='width: 858px' class='clearfix'>
                   <tr>
                       <td> Brand Name: </td>
                       <td>{0}</td>
                   </tr>

                   <tr>
                       <td> Email: </td>
                       <td>{1}</td>
                   </tr>

                   <tr>
                       <td> Password: </td>
                       <td>  &nbsp;</td>
                   </tr>

                   <tr>
                       <td> Contact: </td>
                       <td>{2}</td>
                   </tr>

                   <tr>
                       <td>Description: </td>
                       <td>{3}</td>
                   </tr>

                   <tr>
                       <td> Location: </td>
                       <td>{4}</td>
                   </tr>

                   <tr>
                       <td> Keywords: </td>
                       <td> &nbsp;</td>
                   </tr>

                   <tr>
                       <td> Image: </td>
                       <td><img src='../images/brands/{6}' height='300px' /></td>
                   </tr>

                   <tr>
                       <td> Category: </td>
                       <td>{5}</td>
                   </tr>
            </table>
            ", brand.brand_name, brand.email, brand.contact, brand.description, brand.location, brand.category, brand.image));
                        lblTest.Text = sb.ToString();
                    }
                }
                else
                {
                    //No Brand Detail Found
                    lblTest.Text = "Brand Detail Not Found";
                }
            }
            
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            int brand_id = 0;
            //To Get Brand ID
            string email = Session["login"].ToString();
            List<brandClass> brandDetail = brandDAL.GetBrandDetailsByEmail(email);
            if (brandDetail.Count == 1)
            {
                foreach (brandClass brand in brandDetail)
                {
                    brand_id = brand.brand_id;
                }
            }
            //For Uploading Image
            Gallery gallery = new Gallery();

            //File Upload Starts Here
            try
            {
                //Upploading Image Here
                if (FileUpload1.HasFile)
                {
                    //Generating RAndom Number
                    Random rand = new Random();
                    //string imagepath;
                    int guid = rand.Next();
                    string fileName = guid + Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/images/gallery/") + fileName);
                    lblImage.Text = "Image " + fileName + " Successfully Uploaded";
                    gallery.image_name = fileName;
                    //Saving to Database
                    gallery.brand_id = brand_id;
                    gallery.image_title = txtImageName.Text;

                    //Object for DAL
                    GalleryDAL DAL = new GalleryDAL();
                    bool success = DAL.AddImage(gallery);
                    if (success == true)
                    {
                        lblImage.Text = "Image Successfully Added.";
                        txtImageName.Text = "";
                    }
                    else
                    {
                        lblImage.Text = "Failed to Add new Image";
                    }
                }
                else
                {
                    lblImage.Text = "No Image Selected! Failed to upload image.";
                }

            }
            catch (Exception ex)
            {
                lblImage.Text = "Image Upload Failed";
            }
        }
        private void GetImages()
        {
            int brand_id = 0;
            //To Get Brand ID
            string email = Session["login"].ToString();
            List<brandClass> brandDetail = brandDAL.GetBrandDetailsByEmail(email);
            if (brandDetail.Count == 1)
            {
                foreach (brandClass brand in brandDetail)
                {
                    brand_id = brand.brand_id;
                }
            }
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