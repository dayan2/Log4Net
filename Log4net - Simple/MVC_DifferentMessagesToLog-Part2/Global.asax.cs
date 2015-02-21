using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


//Insert the namespace
using log4net;


namespace MVC_DifferentMessagesToLog_Part2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            //Log4net Configurations
            log4net.Config.XmlConfigurator.Configure();

            ILog log = LogManager.GetLogger(typeof(Startup));
            log.Debug("Testing");
        }
    }
}
