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
                Portal.Context.Path = path;
                
                string urlMappingRedirect = Portal.Services.PortalService.GetUrlMappingTo();
                if (!string.IsNullOrWhiteSpace(urlMappingRedirect))
	            {
		             Response.RedirectPermanent(urlMappingRedirect);
	            }

                Portal.porPage page = Portal.Services.PortalService.GetByUrl();
                string html = Portal.Services.PortalService.Render(page.Html);

                ViewData["Html"] = html;
            }
            return View();
        }
    }
}
