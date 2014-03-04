using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Xml;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Net;
using Portal.Control;

namespace Portal.Services
{
    public class PortalService
    {
        /// <summary>
        /// GIPO: Retorna objeto porPage de um WebSite a partir de uma URL
        /// </summary>
        public static Portal.porPage GetByUrl()
        {
            List<string> folders = new List<string>();
            int? idPageFolderParent = null;

            PortalEntities portal = new PortalEntities(Account.Context.GetConnectionStringEntity("Portal"));
            IEnumerable<Portal.porFolder> queryFolder;
            IEnumerable<Portal.porPage> queryPage;
            Portal.porFolder objFolder = new Portal.porFolder();

            string pathFolders = "/";
            string pathPage = Context.Path;

            IdentifyFolderAndPageURL(ref pathFolders, ref pathPage, Context.Path);

            if (!string.IsNullOrWhiteSpace(pathFolders))
            {
                folders.Add("/");

                if (pathFolders.Contains("/") && !pathFolders.Equals("/"))
                {
                    foreach (string pathFolder in pathFolders.Split('/').Where(s => !string.IsNullOrWhiteSpace(s)))
                    {
                        folders.Add(pathFolder);
                    }
                }

                foreach (string folder in folders)
                {
                    queryFolder = from f in portal.porFolders
                                  where f.IdWebSite == Account.Context.WebSite.IdWebSite && f.Name.Equals(folder) && ((idPageFolderParent == null) ? f.IdFolderParent == null : f.IdFolderParent == idPageFolderParent)
                                  select f;

                    objFolder = queryFolder.FirstOrDefault();

                    idPageFolderParent = null;
                    if (objFolder != null)
                    {
                        idPageFolderParent = objFolder.IdFolder;
                    }
                }
            }

            queryPage = from p in portal.porPages
                        where p.IdWebSite == Account.Context.WebSite.IdWebSite && p.Url.Equals(pathPage) && p.IdFolder == idPageFolderParent
                        select p;

            return queryPage.FirstOrDefault();
        }

        /// <summary>
        /// GIPO: Identifica Folders e Page a partir de uma URL (path). Ex.: "/folder1/folder2/folder3/page"
        /// </summary>
        private static void IdentifyFolderAndPageURL(ref string pathFolders, ref string pathPage, string path)
        {
            string[] dirs;

            if (!string.IsNullOrWhiteSpace(path) && path.Contains("/"))
            {
                dirs = path.Split('/');

                for (int i = 0; i < dirs.Count(); i++)
                {
                    if (i == dirs.Count() - 1 || string.IsNullOrWhiteSpace(dirs[i + 1]))
                    {
                        pathPage = dirs[i];
                        break;
                    }
                    else
                    {
                        pathFolders += string.Format("{0}/", dirs[i].Trim());
                    }
                }
            }
            else
            {
                pathFolders = "/";
                pathPage = path;
            }

            if (string.IsNullOrWhiteSpace(pathPage))
            {
                pathPage = "/";
            }
        }

        /// <summary>
        /// GIPO: Retorna HTML com todos os Controles, Javascripts e CSSs renderizados
        /// </summary>
        public static string Render(string contentHtml)
        {
            //TODO: RenderJS
            //TODO: RenderCSS
            return ControlService.RenderControls(contentHtml);
        }

        /// <summary>
        /// GIPO: Retorna Url a ser redirecionado
        /// </summary>
        public static string GetUrlMappingTo()
        {
            PortalEntities portal = new PortalEntities(Account.Context.GetConnectionStringEntity("Portal"));
            IEnumerable<Portal.porUrlMapping> queryUrlMapping;
            string UrlTo = null;

            queryUrlMapping =   from um in portal.porUrlMappings
                                where um.IdWebSite == Account.Context.WebSite.IdWebSite && um.UrlFrom.Equals(Account.Context.PathAndQuery) && (um.DtFrom <= DateTime.Now && um.DtTo >= DateTime.Now)
                                select um;

            if (queryUrlMapping.FirstOrDefault() != null)
            {
                UrlTo = queryUrlMapping.FirstOrDefault().UrlTo;
            }

            return UrlTo;
        }
    }
}