using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace MVC_DifferentMessagesToLog_Part2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(HomeController));
                        
            //log.Debug("This is a debug level logging event");
            //log.Info("This is an Info level logging event");
            //log.Warn("This is a Warn level logging event");
            //log.Error("This is an error level logging event");
            //log.Fatal("This is a Fatal level logging event");


            //another Way
            const string format = "This is a [{}] level loggin event...";

            log.DebugFormat(format, "Debug");
            log.InfoFormat(format, "Info");
            log.WarnFormat(format, "Warn");
            log.ErrorFormat(format, "Error");
            log.FatalFormat(format, "Fatal");


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}