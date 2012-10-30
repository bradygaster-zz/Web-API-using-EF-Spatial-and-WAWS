namespace EF_Spatial_Web_API_WAWS.Migrations
{
    using EF_Spatial_Web_API_WAWS.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Spatial;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_Spatial_Web_API_WAWS.Models.SpatialDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }


        protected override void Seed(EF_Spatial_Web_API_WAWS.Models.SpatialDemoContext context)
        {
            context.Locations.AddOrUpdate((x) => x.Name,
                new LocationEntity { Name = "The Wing Dome", Address = "7818 Greenwood Avenue North, Seattle WA", Coordinates = DbGeography.FromText("POINT(-122.35499 47.68609)") },
                new LocationEntity { Name = "Kona Kitchen", Address = "8501 5th Ave NE, Seattle WA", Coordinates = DbGeography.FromText("POINT(-122.32338 47.69068)") },
                new LocationEntity { Name = "Wing Central on the Ave", Address = "4524 University Way Northeast, Seattle WA", Coordinates = DbGeography.FromText("POINT(-122.31302 47.66182)") },
                new LocationEntity { Name = "J. Michael's Pub and Eatery", Address = "15770 Redmond Way, Redmond WA", Coordinates = DbGeography.FromText("POINT(122.12975 47.67434)") },
                new LocationEntity { Name = "Charlies Flame Broiled Burgers", Address = "1006 Lake Street South, Kirkland WA", Coordinates = DbGeography.FromText("POINT(-122.20642 47.6674)") },
                new LocationEntity { Name = "The Wing Dome", Address = "232 Central Way, Kirkland WA", Coordinates = DbGeography.FromText("POINT(-122.19963 47.67861)") },
                new LocationEntity { Name = "Jillian's Billiards Club", Address = "731 Westlake Avenue North, Seattle WA", Coordinates = DbGeography.FromText("POINT(-122.33939 47.62633)") },
                new LocationEntity { Name = "Malarkey's Sports Grill", Address = "1025 Northwest Gilman Boulevard, Issaquah WA", Coordinates = DbGeography.FromText("POINT(-122.05334   47.54516)") }
            );
        }
    }

}
