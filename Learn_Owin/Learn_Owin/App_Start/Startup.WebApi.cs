using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Learn_Owin.App_Start
{
    public partial class Startup
    {
        public static class WebApi
        {
            // Install-Package Microsoft.AspNet.WebApi.OwinSelfHost
            // Install-Package Microsoft.Owin.Host.SystemWeb  --> For IIS
            public static void Configure(IAppBuilder app)
            {
                HttpConfiguration config = new HttpConfiguration();
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                 name: "DefaultApi",
                 routeTemplate: "api/{controller}/{id}",
                 defaults: new { id = RouteParameter.Optional }
                );
                
                app.UseWebApi(ODataApi.Configure(config));
            }
    
        }

    }
}