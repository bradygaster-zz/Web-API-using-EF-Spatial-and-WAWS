using System.Web;
using System.Web.Mvc;

namespace EF_Spatial_Web_API_WAWS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}