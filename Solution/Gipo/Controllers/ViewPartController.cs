using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gipo.Controllers
{
    public class ViewPartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu(string parameter)
        {
            ViewData["Html"] = "<p>ViewPart do Menu</p>";
            return View();
        }
    }
}
