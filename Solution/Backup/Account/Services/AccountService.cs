using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Account.Services
{
    public class AccountService
    {
        public accWebSite GetWebSiteByDomain(string Domain, string ConnectionStringEntity)
        {
            AccountEntities account = new AccountEntities(ConnectionStringEntity);
            IEnumerable<Account.accWebSite> queryWebSite;

            queryWebSite = from ws in account.accWebSites
                           where ws.Domain.Equals(Domain)
                           select ws;

            return queryWebSite.FirstOrDefault();
        }

        public accWebSite GetWebSiteByDomainGipo(string Domain, string ConnectionStringEntity)
        {
            AccountEntities account = new AccountEntities(ConnectionStringEntity);
            IEnumerable<Account.accWebSite> queryWebSite;

            queryWebSite = from ws in account.accWebSites
                           where ws.DomainGipo.Equals(Domain)
                           select ws;

            return queryWebSite.FirstOrDefault();
        }
    }
}