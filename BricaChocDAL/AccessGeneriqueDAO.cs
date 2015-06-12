<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BricaChocDAL.Exceptions;

namespace BricaChocDAL
{
    public abstract class AccessGeneriqueDAO<T>
    {
        // requêtes SQL
        protected string sqlInsert;
        protected string sqlUpdate;
        protected string sqlDelete;
        protected string sqlRetrieve;
        protected string sqlRetrieveAll;
        // Affectation des parametres de la proc stockée à partir de l'objet
        protected abstract void ObjectToCommandParameters(T obj, DbCommand oCommand);
        // Affectation des propriétés de l'objet (à créer )à partir du rdr
        protected abstract T ReaderToObject(DbDataReader rdr);
        // Affectation de la clé d'acces base
        protected abstract void KeyToCommandParameters(object id, DbCommand oCommand);
        public virtual int Insert(T obj)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                // création commande
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = sqlInsert;
                    oCommand.CommandType = CommandType.StoredProcedure;
                    // affectation des parametres
                    ObjectToCommandParameters(obj, oCommand);
                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage
                                ("L'opération d'insertion n'a pas été réalisée");
                        // Récupération identifiant créé automatiquement - par convention, le dernier de la collection
                        // récup du parametre de sortie
                        int nbParam = oCommand.Parameters.Count;
                        int id = (int)oCommand.Parameters[nbParam - 1].Value;
                        return id;
                        // Pour ne pas obliger chaque proc sto Insert à retourner un identifiant int
                        // on pourrait retourner la valeur du dernier parametre sous forme d'objet

                    }
                    catch (DbException de)
                    {
                        throw new DaoExceptionAfficheMessage
                            ("Une erreur s'est produite sur la base : \n" + de.Message, de);
                    }
                }
            }
        }
        public virtual void Update(T obj)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                // création commande
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    try
                    {
                        oCommand.CommandText = sqlUpdate;
                        oCommand.CommandType = CommandType.StoredProcedure;

                        ObjectToCommandParameters(obj, oCommand);

                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération de mise à jour n'a pas été réalisée");
                    }
                    catch (DbException se)
                    {
                        throw new DaoExceptionAfficheMessage("Une erreur s'est produite sur la base : \n" + se.Message, se);
                    }
                }
            }

        }
        public virtual void Delete(T obj)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                // création commande
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    try
                    {
                        oCommand.CommandText = sqlDelete;
                        oCommand.CommandType = CommandType.StoredProcedure;

                        // affectation parametres à la commande
                        ObjectToCommandParameters(obj, oCommand);

                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération de suppression n'a pas été réalisée");
                    }
                    catch (DbException se)
                    {
                        throw new DaoExceptionAfficheMessage("Une erreur s'est produite sur la base : \n" + se.Message, se);
                    }
                }
            }

        }
        public virtual T GetById(object id)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = sqlRetrieve;
                    oCommand.CommandType = CommandType.StoredProcedure;

                    T obj = default(T);
                    // affectation de la clé
                    KeyToCommandParameters(id, oCommand);
                    try
                    {
                        using (DbDataReader rdr = oCommand.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                // création de l'objet
                                obj = ReaderToObject(rdr);
                            }
                            rdr.Close();
                        }
                        return obj;
                    }
                    catch (DbException se)
                    {
                        throw new DaoExceptionAfficheMessage("Une erreur s'est produite sur la base : \n" + se.Message, se);
                    }
                }
            }
        }
        public virtual ICollection<T> GetAll()
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {

                    oCommand.CommandText = sqlRetrieveAll;
                    oCommand.CommandType = CommandType.StoredProcedure;

                    T obj;
                    IList<T> liste = new List<T>();
                    using (DbDataReader rdr = oCommand.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            // création de l'objet
                            obj = ReaderToObject(rdr);
                            liste.Add(obj);
                        }
                        rdr.Close();
                    }

                    return liste;
                }
            }

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BricaChocDAL.Exceptions;

namespace BricaChocDAL
{
    public abstract class AccessGeneriqueDAO<T>
    {
        // requêtes SQL
        protected string sqlInsert;
        protected string sqlUpdate;
        protected string sqlDelete;
        protected string sqlRetrieve;
        protected string sqlRetrieveAll;
        // Affectation des parametres de la proc stockée à partir de l'objet
        protected abstract void ObjectToCommandParameters(T obj, DbCommand oCommand);
        // Affectation des propriétés de l'objet (à créer )à partir du rdr
        protected abstract T ReaderToObject(DbDataReader rdr);
        // Affectation de la clé d'acces base
        protected abstract void KeyToCommandParameters(object id, DbCommand oCommand);
        public virtual int Insert(T obj)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                // création commande
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = sqlInsert;
                    oCommand.CommandType = CommandType.StoredProcedure;
                    // affectation des parametres
                    ObjectToCommandParameters(obj, oCommand);
                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage
                                ("L'opération d'insertion n'a pas été réalisée");
                        // Récupération identifiant créé automatiquement - par convention, le dernier de la collection
                        // récup du parametre de sortie
                        int nbParam = oCommand.Parameters.Count;
                        int id = (int)oCommand.Parameters[nbParam - 1].Value;
                        return id;
                        // Pour ne pas obliger chaque proc sto Insert à retourner un identifiant int
                        // on pourrait retourner la valeur du dernier parametre sous forme d'objet

                    }
                    catch (DbException de)
                    {
                        throw new DaoExceptionAfficheMessage
                            ("Une erreur s'est produite sur la base : \n" + de.Message, de);
                    }
                }
            }
        }
        public virtual void Update(T obj)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                // création commande
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    try
                    {
                        oCommand.CommandText = sqlUpdate;
                        oCommand.CommandType = CommandType.StoredProcedure;

                        ObjectToCommandParameters(obj, oCommand);

                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération de mise à jour n'a pas été réalisée");
                    }
                    catch (DbException se)
                    {
                        throw new DaoExceptionAfficheMessage("Une erreur s'est produite sur la base : \n" + se.Message, se);
                    }
                }
            }

        }
        public virtual void Delete(T obj)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                // création commande
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    try
                    {
                        oCommand.CommandText = sqlDelete;
                        oCommand.CommandType = CommandType.StoredProcedure;

                        // affectation parametres à la commande
                        ObjectToCommandParameters(obj, oCommand);

                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération de suppression n'a pas été réalisée");
                    }
                    catch (DbException se)
                    {
                        throw new DaoExceptionAfficheMessage("Une erreur s'est produite sur la base : \n" + se.Message, se);
                    }
                }
            }

        }
        public virtual T GetById(object id)
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = sqlRetrieve;
                    oCommand.CommandType = CommandType.StoredProcedure;

                    T obj = default(T);
                    // affectation de la clé
                    KeyToCommandParameters(id, oCommand);
                    try
                    {
                        using (DbDataReader rdr = oCommand.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                // création de l'objet
                                obj = ReaderToObject(rdr);
                            }
                            rdr.Close();
                        }
                        return obj;
                    }
                    catch (DbException se)
                    {
                        throw new DaoExceptionAfficheMessage("Une erreur s'est produite sur la base : \n" + se.Message, se);
                    }
                }
            }
        }
        public virtual ICollection<T> GetAll()
        {
            // création connection
            using (DbConnection oConnection = Connection.GetConnection())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {

                    oCommand.CommandText = sqlRetrieveAll;
                    oCommand.CommandType = CommandType.StoredProcedure;

                    T obj;
                    IList<T> liste = new List<T>();
                    using (DbDataReader rdr = oCommand.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            // création de l'objet
                            obj = ReaderToObject(rdr);
                            liste.Add(obj);
                        }
                        rdr.Close();
                    }

                    return liste;
                }
            }

        }
    }
}
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
