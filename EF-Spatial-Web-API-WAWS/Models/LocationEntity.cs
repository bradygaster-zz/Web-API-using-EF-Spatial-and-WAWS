using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Web;

namespace EF_Spatial_Web_API_WAWS.Models
{
    public class LocationEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DbGeography Coordinates { get; set; }
    }

}