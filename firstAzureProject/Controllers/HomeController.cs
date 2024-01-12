using log4net;
using log4net.Config;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Web.Mvc;


namespace firstAzureProject.Controllers
{
    public class HomeController : Controller
    {
        ILog log = LogManager.GetLogger(typeof(HomeController));// = LogManager.GetLogger(typeof(HomeController));
       //public static ILogger log;
        public ActionResult Index()
        {
           
            //using ILoggerFactory loggerfactory = LoggerFactory.Create(builder =>
            //builder.AddProvider(new Log4NetProvider(logpath.ToString())));
            //log = loggerfactory.CreateLogger(typeof(HomeController));
            log.Debug("Debug message");
            log.Warn("Warn message");
            log.Error("Error message");
        
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