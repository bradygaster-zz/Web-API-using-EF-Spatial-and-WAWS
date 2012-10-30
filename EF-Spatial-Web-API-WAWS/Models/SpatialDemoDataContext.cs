using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Spatial_Web_API_WAWS.Models
{
    public class SpatialDemoContext : System.Data.Entity.DbContext
    {
        public SpatialDemoContext()
            : base("name=SpatialDemoConnectionString")
        {
        }


        public System.Data.Entity.DbSet<LocationEntity> Locations { get; set; }
    }

}