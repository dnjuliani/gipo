using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Web.UI;

namespace Gipo.Controllers
{
    public class FrontController : Controller
    {
        public ActionResult Index(string path)
        {
            if (this.HttpContext != null)
            {
                Portal.tb_prt_Page page = Portal.Services.PortalService.GetByUrl(1, path);
                ViewData["Html"] = page.Html;
            }
            return View();
        }
    }
}
