using System.Web.Mvc;
using System.Web.Routing;
namespace CarInsurance
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "Insuree", action = "Create", id = UrlParameter.Optional });
        }
    }
}
