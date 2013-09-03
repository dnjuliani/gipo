using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Portal.Services
{
    public class PortalService
    {
        /// <summary>
        /// GIPO: Retorna objeto tb_prt_Page de um WebSite a partir de uma URL
        /// </summary>
        public static Portal.tb_prt_Page GetByUrl(int idWebSite, string path)
        {
            List<string> folders = new List<string>();
            int? idPageFolderParent = null;

            PortalEntities portal = new PortalEntities(GetConnectionString());
            IEnumerable<Portal.tb_prt_Folder> queryFolder;
            IEnumerable<Portal.tb_prt_Page> queryPage;
            Portal.tb_prt_Folder objFolder = new Portal.tb_prt_Folder();

            string pathFolders = "/";
            string pathPage = path;

            IdentifyFolderAndPageURL(ref pathFolders, ref pathPage, path);

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
                    queryFolder = from f in portal.tb_prt_Folder
                                  where f.Name.Equals(folder) && ((idPageFolderParent == null) ? f.IdFolderParent == null : f.IdFolderParent == idPageFolderParent)
                                  select f;

                    objFolder = queryFolder.FirstOrDefault();

                    idPageFolderParent = null;
                    if (objFolder != null)
                    {
                        idPageFolderParent = objFolder.IdFolder;
                    }
                }
            }

            queryPage = from p in portal.tb_prt_Page
                        where p.Url.Equals(pathPage) && p.IdFolder == idPageFolderParent
                        select p;

            return queryPage.FirstOrDefault();
        }

        /// <summary>
        /// GIPO: Obtem connectionString para acesso ao PortalEntities
        /// </summary>
        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PortalEntities"].ConnectionString;
            connectionString = connectionString.Replace("{VAR_CONNECTIONSTRING}", Cms.Context.ConnectionString);
            return connectionString;
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
        }
    }
}