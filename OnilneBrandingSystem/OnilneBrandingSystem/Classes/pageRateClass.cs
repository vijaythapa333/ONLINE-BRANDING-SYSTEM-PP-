using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnilneBrandingSystem.Classes
{
    public class pageRateClass
    {
        public int page_rate_id { get; set; }
        public int brand_id { get; set; }
        public int total_rating { get; set; }
        public int no_of_rating { get; set; }
        public string user { get; set; }
    }
}