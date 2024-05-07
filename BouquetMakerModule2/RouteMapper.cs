using DotNetNuke.Web.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dnn.Bce.BouquetMakerModule2
{
    public class RouteMapper //: IMvcRouteMapper
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "BouquetMakerModule2",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Dnn.Bce.BouquetMakerModule2.Controllers" }
            );
        }
    }
}