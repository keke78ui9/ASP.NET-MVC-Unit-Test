using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcNinjectUnitTest.BusinessLogic;

namespace MvcNinjectUnitTest.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
            :this(null)
        { }

        IServiceProvider _service;
        public HomeController(IServiceProvider service)
        {
            _service = service ?? new ServiceProvider();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Product()
        {
            IProductBzService service = _service.GetProductBzServicer();            

            return View();
        }
    }
}
