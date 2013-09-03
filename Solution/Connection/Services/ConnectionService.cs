using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection.Services
{
    public class ConnectionService
    {
        /// <summary>
        /// GIPO: Obtem connectionString a partir do SubDominio / Dominio
        /// </summary>
        public static string GetConnectionString(string SubDomain)
        {
            ConnectionEntities connection = new ConnectionEntities();

            IEnumerable<tb_con_Connection> queryConnection = from c in connection.tb_con_Connection
                                                             where c.Site.Contains(SubDomain)
                                                             select c;

            tb_con_Connection connectionCurrent = queryConnection.FirstOrDefault();

            if (connectionCurrent == null)
            {
                throw new SystemException("Erro C001 - Não existe conexão para o domínio solicitado. Verifique a URL digitada.");
            }

            return connectionCurrent.ConnectionString;
        }
    }
}