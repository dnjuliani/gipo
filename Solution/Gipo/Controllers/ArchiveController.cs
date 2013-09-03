using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gipo.Controllers
{
    public class ArchiveController : Controller
    {
        //
        // GET: /Archive/

        public ActionResult Index(string parameter)
        {
            ViewData["Html"] = "<p>Archive</p>";
            return View();
        }

    }
}
