using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Routing;

namespace NextEraQuizApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //GlobalConfiguration.Configuration.Routes.Add("Default",
            //    new HttpRoute("{controller}")); 
            var config = GlobalConfiguration.Configuration;

            //AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(config);
            //Bootstrapper.Run();
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalConfiguration.Configuration.EnsureInitialized();
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
    }
}