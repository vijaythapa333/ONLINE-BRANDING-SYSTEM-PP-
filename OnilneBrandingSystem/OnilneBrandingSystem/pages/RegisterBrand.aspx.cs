using OnilneBrandingSystem.Classes;
using OnilneBrandingSystem.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnilneBrandingSystem.pages
{
    public partial class RegisterBrand : System.Web.UI.Page
    {
        brandClass brand = new brandClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            brand.brand_name = txtBrandName.Text;
            brand.email = txtEmail.Text;
            brand.password = txtPassword.Text;
            brand.contact = txtContact.Text;
            brand.description = txtDescription.Text;
            brand.keywords = txtKeywords.Text;
            brand.location = txtLocation.Text;
            brand.addedDate = DateTime.Now;
            brand.category = DropDownList1.SelectedValue.ToString();
            brand.image = "no-image.jpg";

            //File Upload Starts Here
            try
            {
                //Upploading Image Here
                if (FileUploadImage.HasFile)
                {
                    //Generating RAndom Number
                    Random rand = new Random();
                    //string imagepath;
                    int guid = rand.Next();
                    string fileName = guid+Path.GetFileName(FileUploadImage.FileName);
                    FileUploadImage.PostedFile.SaveAs(Server.MapPath("~/images/brands/") + fileName);
                    lblImage.Text = "Image " + fileName + " Successfully Uploaded";
                    //Response.Redirect(Request.Url.AbsoluteUri);
                    //Page_Load(sender, e);
                    brand.image = fileName;
                }
                else
                {
                    lblImage.Text = "No Image Selected";
                }

            }
            catch (Exception ex)
            {
                lblImage.Text = "Image Upload Failed";
            }
            finally
            {

            }
            //File Upload Ends Here

            //Object for DAL
            brandDAL DAL = new brandDAL();
            bool success=DAL.AddBrand(brand);
            if(success==true)
            {
                lblResult.Text = "Brand Successfully Added.";
                Clear();
            }
            else
            {
                lblResult.Text = "Failed to Add new Brand";
            }
        }
        private void Clear()
        {
            txtBrandName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtDescription.Text = "";
            txtKeywords.Text = "";
            txtLocation.Text = "";
        }
    }
}