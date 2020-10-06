using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "about",
                "about",
                defaults: new { controller = "Home", action = "Sobre" }
            );

            routes.MapRoute(
                "paginas",
                "paginas",
                defaults: new { controller = "Paginas", action = "Index" }
            );

            routes.MapRoute(
                "pagina_novo",
                "pagina/novo",
                defaults: new { controller = "Paginas", action = "Novo" }
            );

            routes.MapRoute(
                "contact",
                "contact",
                defaults: new { controller = "Home", action = "Contatos" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
