using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BeerUAPI.Controllers;
using BeerUAPI.Data;
using Microsoft.Practices.Unity;
using Newtonsoft.Json;

namespace BeerUAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private void ConfigureApi(HttpConfiguration config)
        {
            var unity = new UnityContainer();
            unity.RegisterType<BaseController>();
            unity.RegisterType<BreweryDBController>();

            unity.RegisterType<BaseRepository>();
            unity.RegisterType<IBreweryDbRepository, BreweryDbRepository>();


            config.DependencyResolver = new IoCContainer(unity);
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling
                = ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Remove(
                GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigureApi(GlobalConfiguration.Configuration);

        }
    }
}
