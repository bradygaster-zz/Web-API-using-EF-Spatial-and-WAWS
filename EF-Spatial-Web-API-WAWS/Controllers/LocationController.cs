using EF_Spatial_Web_API_WAWS.Models;
using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EF_Spatial_Web_API_WAWS.Controllers
{
    public class LocationController : ApiController
    {
        SpatialDemoContext db;


        public LocationController()
        {
            db = new SpatialDemoContext();
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


        public IEnumerable<Location> Get(string longitude, string latitude)
        {
            var qry = string.Format("POINT({0} {1})", longitude, latitude);


            var results = (from s in db.Locations
                           orderby s.Coordinates.Distance(DbGeography.FromText(qry))
                           select new Location
                           {
                               Name = s.Name,
                               Address = s.Address,
                               Longitude = s.Coordinates.Longitude.Value,
                               Latitude = s.Coordinates.Latitude.Value,
                               Distance = (s.Coordinates.Distance(DbGeography.FromText(qry)).Value * 0.000621371)
                           }).Take(5).ToList<Location>();


            return results;
        }
    }

}
