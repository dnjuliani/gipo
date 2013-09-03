using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cms
{
    public static class Context
    {
        private static int? _IdWebSite;
        public static int? IdWebSite 
        {
            get
            {
                if (_IdWebSite == null)
                {
                    _IdWebSite = 1;
                }
                return _IdWebSite;
            }
            set
            {
                _IdWebSite = value;
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
    }
}