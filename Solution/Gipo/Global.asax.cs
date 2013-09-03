using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Gipo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "ViewPart",
                "viewpart/{action}/{parameter}",
                new { controller = "ViewPart", action = "Index", parameter = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Archive",
                "archive/{parameter}",
                new { controller = "Archive", action = "Index", parameter = UrlParameter.Optional }
            );

            routes.MapRoute(
                "FavIcon",
                "favicon.ico",
                new { controller = "FavIcon", action = "Index" }
            );
            
            routes.MapRoute(
                "Robots",
                "robots.txt",
                new { controller = "Robots", action = "Index" }
            );

            routes.MapRoute(
                "Front",
                "{*path}",
                new { controller = "Front", action = "Index", path = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}