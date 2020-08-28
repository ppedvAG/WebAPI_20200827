using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace _007_WebAPIRouting
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();


            // school route -> http://localhost:1234/api/myschool
            config.Routes.MapHttpRoute(
                name: "School",
                routeTemplate: "api/myschool/{id}",
                defaults: new { controller = "School", id = RouteParameter.Optional },
                constraints: new { id = @"\d*" }
            ); 

            //Default Route 
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            #region Alternative Schreibweise von MapRoutes (MapRoutes verwendet die IHttpRoute

            // define route
            //IHttpRoute defaultRoute = config.Routes.CreateRoute("api/{controller}/{id}",
            //                                    new { id = RouteParameter.Optional }, null);
            //// Add route
            //config.Routes.Add("DefaultApi", defaultRoute);

            #endregion
        }
    }
}
