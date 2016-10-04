using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Test1MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();


            /** Create Custom Routes 1ra Forma sin AttributesRoutes- The order of this Routes Manner. From the Most Specific hasta la mas Generica.El mas Commun que se usa es el que tiene tres parametros Name,Url, Default. To specifi the third Parameter the Default we use a anonymous object for that. Este Default Rout no Tiene Optional parameters. El otro Argumento despues de Default es para Validar las Urls el year y el month.la d siginifica digito y el 4 significa cuatro digitos.El @ se pone pq blackslack es un escape parametro y el Month se restringe a dos Digitos.
            routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new {controller = "Movies", action = "ByReleaseDate", },
                new {year = @"2015|2016",month = @"\d{2}" }
                );  **/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
