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
                string urlMappingRedirect = Portal.Services.PortalService.GetUrlMappingTo(Account.Context.WebSite.IdWebSite, Account.Context.PathAndQuery);
                if (!string.IsNullOrWhiteSpace(urlMappingRedirect))
	            {
		             Response.RedirectPermanent(urlMappingRedirect);
	            }                

                Portal.porPage page = Portal.Services.PortalService.GetByUrl(Account.Context.WebSite.IdWebSite, path);
                string html = Portal.Services.PortalService.Render(page.Html);
                ViewData["Html"] = html;
            }
            return View();
        }
    }
}
