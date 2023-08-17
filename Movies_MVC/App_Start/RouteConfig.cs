using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Movies_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            //Attribute Routing (use this)
            routes.MapMvcAttributeRoutes();
            
            /* new Custom Map Route(training purposes)
            routes.MapRoute(
                "MoviesbyReleaseDate", 
                "movies/released/{year}/{month}",
                //argument for defining controller and action
                new{controller="Movies", action="ByReleaseDate"},
                //argument for specifying map routing: year=4 digit & month=2 digit else 404 error
                new {year = @"\d{4}", month=@"\d{2}"}
            );
            */
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}