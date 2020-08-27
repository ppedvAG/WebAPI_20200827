using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _001_MyFirstWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //BeispielURL: localhost:12345/Product/123/RelatedProducts

            // Web API routes
            config.MapHttpAttributeRoutes();

            //Default Route 
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
