﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NewRelicDotNetAgentAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "NewRelicAPI",
                routeTemplate: "api/{controller}/{action}"
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
