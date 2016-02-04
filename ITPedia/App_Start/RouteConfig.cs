using System.Web.Mvc;
using System.Web.Routing;

namespace DB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Dictionary", "Dictionary/{action}/{id}", new
            {
                controller = "Dictionary",
                action = "Index",
                id = UrlParameter.Optional
            });

            routes.MapRoute("Default", "{controller}/{action}/{id}", new
            {
                controller = "Home",
                action = "Index",
                id = UrlParameter.Optional
            });
        }
    }
}