using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Connection.Services
{
    public class ConnectionService
    {
        /// <summary>
        /// GIPO: Obtem connectionString a partir do Domínio
        /// </summary>
        public string GetConnectionStringByDomain(string Domain)
        {
            ConnectionEntities connection = new ConnectionEntities();

            IEnumerable<conConnection> queryConnection = from c in connection.conConnections
                                                         where c.Domain.Contains(Domain)
                                                         select c;

            conConnection connectionCurrent = queryConnection.FirstOrDefault();

            if (connectionCurrent == null)
            {
                throw new SystemException("Erro C001 - Não existe conexão para o domínio solicitado. Verifique a URL digitada.");
            }

            return connectionCurrent.ConnectionString;
        }

        /// <summary>
        /// GIPO: Obtem connectionString a partir do DomínioGipo
        /// </summary>
        public string GetConnectionStringByDomainGipo(string DomainGipo)
        {
            ConnectionEntities connection = new ConnectionEntities();

            IEnumerable<conConnection> queryConnection = from c in connection.conConnections
                                                         where c.DomainGipo.Contains(DomainGipo)
                                                         select c;

            conConnection connectionCurrent = queryConnection.FirstOrDefault();

            if (connectionCurrent == null)
            {
                throw new SystemException("Erro C001 - Não existe conexão para o domínio solicitado. Verifique a URL digitada.");
            }

            return connectionCurrent.ConnectionString;
        }
    }
}