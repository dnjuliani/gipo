using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Account;
using Account.Services;


namespace Cms
{
    public static class Context
    {
        private static accWebSite _WebSite;
        public static accWebSite WebSite 
        {
            get
            {
                if (_WebSite == null)
                {
                    _WebSite = Account.Services.AccountService.GetWebSite(SubDomain, Cms.Context.GetConnectionStringEntity("AccountEntities"));
                }
                return _WebSite;
            }
        }

        public static string ConnectionString
        {
            get 
            {
                return Connection.Services.ConnectionService.GetConnectionString(SubDomain);
            }
        }

        public static string Domain
        {
            get
            { 
                return HttpContext.Current.Request.Url.Host;
            }
        }

        public static string SubDomain
        {
            get
            {
                foreach (string dir in HttpContext.Current.Request.Url.Host.Split('.'))
                {
                    if (!dir.ToLower().Trim().Equals("www"))
	                {
	                    return dir.Replace("debug-","");
	                }
                }
                return "";
            }
        }

        public static string GetConnectionStringEntity(string Entity)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[Entity].ConnectionString;
            connectionString = connectionString.Replace("{VAR_CONNECTIONSTRING}", Context.ConnectionString);
            return connectionString;
        }
    }
}