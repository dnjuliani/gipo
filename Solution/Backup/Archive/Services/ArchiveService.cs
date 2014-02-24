using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;

namespace Archive.Services
{
    public class ArchiveService
    {
        /// <summary>
        /// GIPO: Retorna objeto arcArchive a partir de um nome
        /// </summary>
        public static Archive.arcArchive GetByName(string name)
        {
            ArchiveEntities archive = new ArchiveEntities(Account.Context.GetConnectionStringEntity("Archive"));
            IEnumerable<Archive.arcArchive> queryArchive;

            queryArchive =  from a in archive.arcArchives
                            where a.Name.Equals(name)
                            select a;

            return queryArchive.FirstOrDefault();
        }

        /// <summary>
        /// GIPO: Retorna objeto arcArchive a partir de um ID
        /// </summary>
        public static Archive.arcArchive GetById(int id)
        {
            ArchiveEntities archive = new ArchiveEntities(Account.Context.GetConnectionStringEntity("Archive"));
            IEnumerable<Archive.arcArchive> queryArchive;

            queryArchive = from a in archive.arcArchives
                           where a.IdArchive == id
                           select a;

            return queryArchive.FirstOrDefault();
        }

        /// <summary>
        /// GIPO: Retorna CSS a partir do nome
        /// </summary>
        public static string GetArchiveText(string name, string rootPath)
        {
            Archive.arcArchive arcArchive = GetByName(name);

            StreamReader strReader = new StreamReader(string.Format("{0}{1}", rootPath, arcArchive.Path));
            string arcContentLine = "";
            string arcContentTotal = "";

            while (arcContentLine != null)
            {
                arcContentLine = strReader.ReadLine();
                if (arcContentLine != null)
                {
                    arcContentTotal += arcContentLine + "\r\n";
                }
            }

            strReader.Close();
            strReader.Dispose();

            return arcContentTotal;
        }

        /// <summary>
        /// GIPO: Retorna Archive em Byte a partir do nome
        /// </summary>
        public static byte[] GetArchiveByte(string name, string rootPath)
        {
            Archive.arcArchive arcArchive = GetByName(name);

            FileStream fileStream = new FileStream(string.Format("{0}{1}", rootPath, arcArchive.Path), FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] archiveByte = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            return archiveByte;
        }
    }
}