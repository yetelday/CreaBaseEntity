using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BricaChocDAL.Exceptions;

namespace BricaChocDAL
{
    class Connection
    {
        static public DbConnection GetConnection()
        {
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["BricaChoc"];
            // affectation de la chaine de connection extraite
            if (oConfig == null) // chaine de connexion non trouvée
                throw new DaoExceptionFinAppli("La base est inaccessible, l'appplication va se fermer, recommencez ultérieurement: \n"
                    + "La chaine de connexion est introuvable");
            else
            {
                DbProviderFactory oFabrique = DbProviderFactories.GetFactory(oConfig.ProviderName);
                DbConnection oConnection = oFabrique.CreateConnection();
                oConnection.ConnectionString = oConfig.ConnectionString;
                try
                {
                    oConnection.Open();
                    return oConnection;
                }
                catch (DbException dbe)
                {
                    throw new DaoExceptionFinAppli("Connexion à la base impossible", dbe);
                }

            }
        }
    }
}
