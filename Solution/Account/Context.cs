using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Account
{
    public class Context
    {
        private static accWebSite _WebSite;
        public static accWebSite WebSite
        {
            get
            {
                if (_WebSite == null)
                {
                    Account.Services.AccountService account = new Account.Services.AccountService();
                    if (IsDomainGipo)
                    {
                        _WebSite = account.GetWebSiteByDomainGipo(DomainGipo, GetConnectionStringEntity("Account"));
                    }
                    else
                    {
                        _WebSite = account.GetWebSiteByDomain(Domain, GetConnectionStringEntity("Account"));
                    }
                }
                return _WebSite;
            }
        }

        private static string _ConnectionString;
        public static string ConnectionString
        {
            get
            {
                if (_ConnectionString == null)
                {
                    Connection.Services.ConnectionService connection = new Connection.Services.ConnectionService();
                    if (IsDomainGipo)
                    {
                        _ConnectionString = connection.GetConnectionStringByDomainGipo(DomainGipo);
                    }
                    else
                    {
                        _ConnectionString = connection.GetConnectionStringByDomain(Domain);
                    }
                }
                return _ConnectionString;                
            }
        }

        private static string _Domain;
        public static string Domain
        {
            get
            {
                _Domain = HttpContext.Current.Request.Url.Host;
                return _Domain;
            }
        }

        private static string _DomainGipo;
        public static string DomainGipo
        {
            get
            {
                if (IsDomainGipo)
                {
                    _DomainGipo = Domain;
                    _DomainGipo = _DomainGipo.Replace("." + ConfigurationManager.AppSettings["GipoDomain"].ToString(), "");
                    _DomainGipo = _DomainGipo.Replace("." + ConfigurationManager.AppSettings["GipoDomainStable"].ToString(), "");
                    _DomainGipo = _DomainGipo.Replace("." + ConfigurationManager.AppSettings["GipoDomainBeta"].ToString(), "");
                    _DomainGipo = _DomainGipo.Replace("." + ConfigurationManager.AppSettings["GipoDomainLocal"].ToString(), "");
                }
                else
                {
                    _DomainGipo = string.Empty;
                }

                return _DomainGipo;
            }
        }

        private static bool _IsDomainGipo;
        public static bool IsDomainGipo
        {
            get
            {
                _IsDomainGipo = (
                                (Domain.Contains(ConfigurationManager.AppSettings["GipoDomain"].ToString())) ||
                                (Domain.Contains(ConfigurationManager.AppSettings["GipoDomainStable"].ToString())) ||
                                (Domain.Contains(ConfigurationManager.AppSettings["GipoDomainBeta"].ToString())) ||
                                (Domain.Contains(ConfigurationManager.AppSettings["GipoDomainLocal"].ToString()))
                                );

                return _IsDomainGipo;
            }
        }

        private static string _PathAndQuery;
        public static string PathAndQuery
        {
            get
            {
                _PathAndQuery = HttpContext.Current.Request.Url.PathAndQuery;
                return _PathAndQuery;
            }
        }

        public static string GetConnectionStringEntity(string Entity)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ModuleEntities"].ConnectionString;
            connectionString = connectionString.Replace("{VAR_CONNECTIONSTRING}", Context.ConnectionString);
            connectionString = connectionString.Replace("{VAR_MODULE}", Entity);
            return connectionString;
        }
    }
}