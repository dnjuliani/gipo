using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Archive.Services;
using System.IO;
using System.Collections;

namespace Gipo.Controllers
{
    public class ArchiveController : Controller
    {
        public ActionResult Index(string parameter)
        {
            return View();
        }

        public ActionResult ByName(string parameter)
        {
            string arcContent = "";
            byte[] arcContentByte;
            string archivePathDefault = "/";
            string archiveExtension = (!string.IsNullOrWhiteSpace(parameter) && parameter.Contains(".") ? parameter.Split('.')[parameter.Split('.').Count() - 1] : "");

            Response.Buffer = true;
            Response.Clear();

            switch (archiveExtension.ToLower())
	        {
                case "css":
                    arcContent = ArchiveService.GetArchiveText(parameter, Server.MapPath(archivePathDefault));
                    HttpContext.Response.ContentType = "text/css";
                    Response.Expires = 10000;
                    break;
                case "js":
                    arcContent = ArchiveService.GetArchiveText(parameter, Server.MapPath(archivePathDefault));
                    HttpContext.Response.ContentType = "text/javascript";
                    Response.Expires = 10000;
                    break;
                case "jpg":
                    arcContentByte = ArchiveService.GetArchiveByte(parameter, Server.MapPath(archivePathDefault));
                    Response.ContentType = "image/jpeg";
                    Response.Expires = 8000;
                    Response.BinaryWrite(arcContentByte);
                    break;
		        default:
                    break;
            }

            ViewData["Archive"] = arcContent;

            return View();
        }

        public ActionResult ById(string parameter)
        {
            int id = 0;
            Archive.arcArchive arcArchive;

            if (int.TryParse(parameter, out id) && id > 0)
            {
                arcArchive = ArchiveService.GetById(id);
            }
            else 
            {
                arcArchive = ArchiveService.GetByName(parameter);
            }

            ViewData["Html"] = arcArchive.Path;
            return View();
        }
    }
}
