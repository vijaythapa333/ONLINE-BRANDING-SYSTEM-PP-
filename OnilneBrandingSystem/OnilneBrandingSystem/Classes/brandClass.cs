using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnilneBrandingSystem.Classes
{
    public class brandClass
    {
        public int brand_id { get; set; }
        public string brand_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string contact { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public string keywords { get; set; }
        public string image { get; set; }
        public string category { get; set; }
        public DateTime addedDate { get; set; }

        //public brandClass(int brand_id,string brand_name,string email,string password,string contact, string location,string description,string keywords, string image, string category, DateTime addedDate)
        //{
        //    this.brand_id = brand_id;
        //    this.brand_name = brand_name;
        //    this.email = email;
        //    this.password = password;
        //    this.contact = contact;
        //    this.location = location;
        //    this.description = description;
        //    this.keywords = keywords;
        //    this.image = image;
        //    this.category = category;
        //    this.addedDate = addedDate;
        //}
        //public brandClass( string brand_name, string email, string password, string contact, string location, string description, string keywords, string image, string category, DateTime addedDate)
        //{
        //    this.brand_name = brand_name;
        //    this.email = email;
        //    this.password = password;
        //    this.contact = contact;
        //    this.location = location;
        //    this.description = description;
        //    this.keywords = keywords;
        //    this.image = image;
        //    this.category = category;
        //    this.addedDate = addedDate;
        //}
    }
}