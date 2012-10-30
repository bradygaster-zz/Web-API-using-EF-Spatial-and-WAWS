using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Spatial_Web_API_WAWS.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Distance { get; set; }
    }

}