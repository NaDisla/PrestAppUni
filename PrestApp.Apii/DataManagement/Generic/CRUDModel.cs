using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.DataManagement.Generic
{
    public class CRUDModel<T> : ICRUDModel<T> where T : class
    {
        #region Config
        //private NorthwindEntities dataContext = null;
        private DbSet<T> dbSet = null;

        //public BaseData()
        //{
        //    this.dataContext = new NorthwindEntities();
        //    dbSet = dataContext.Set<T>();
        //}

        //public BaseData(NorthwindEntities _context)
        //{
        //    this.dataContext = _context;
        //    dbSet = _context.Set<T>();
        //}

        #endregion


        #region CRUD

        #region Select
        public IEnumerable<T> ObtenerTodos()
        {
            try
            {
                return dbSet.ToList();
            }
            catch (SqlException s)
            {
                throw s;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public T Obtener(int id)
        {
            try
            {
                return dbSet.Find(id);
            }
            catch (SqlException s)
            {
                throw s;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public T Obtener(string id)
        {
            try
            {
                return dbSet.Find(id);
            }
            catch (SqlException s)
            {
                throw s;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion


        #region Insert
        public bool Insertar(T entity)
        {
            using (var tran = dataContext.Database.BeginTransaction())
            {
                try
                {
                    dbSet.Add(entity);
                    dataContext.SaveChanges();
                    tran.Commit();
                    return true;
                }
                catch (SqlException s)
                {
                    tran.Rollback();
                    return false;
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    return false;
                }

            }
        }
        public bool Insertar(List<T> entity)
        {
            using (var tran = dataContext.Database.BeginTransaction())
            {
                foreach (var item in entity)
                {
                    try
                    {
                        dbSet.Add(item);
                        dataContext.SaveChanges();
                        tran.Commit();
                        return true;

                    }
                    catch (SqlException s)
                    {
                        tran.Rollback();
                        return false;
                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        return false;
                    }
                }
                return false;
            }
        }

        public virtual T AddGetObject(T entity)
        {
            using (var tran = dataContext.Database.BeginTransaction())
            {
                try
                {
                    var res = dbSet.Add(entity);
                    dataContext.SaveChanges();
                    tran.Commit();
                    return null;
//                    return res;
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    return null;
                }
            }
        }

        #endregion


        #region Update

        public bool Actualizaaar(T nuevo)
        {
            try
            {
                dbSet.Attach(nuevo);
                dataContext.Entry(nuevo).State = EntityState.Modified;
                return dataContext.SaveChanges() > 0;
            }
            catch (SqlException s)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Actualizar(T nuevo)
        {
            try
            {
                dbSet.Update(nuevo);
                return dataContext.SaveChanges() > 0;
            }
            catch (SqlException s)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Actualizar(IEnumerable<T> nuevo)
        {
            try
            {
                foreach (var item in nuevo)
                {
                    dbSet.Update(item);
                }
                return dataContext.SaveChanges() > 0;
            }
            catch (SqlException s)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Actualizaaar(IEnumerable<T> nuevo)
        {
            foreach (var item in nuevo)
            {
                try
                {
                    dbSet.Attach(item);
                    dataContext.Entry(item).State = EntityState.Modified;
                    dataContext.SaveChanges();
                }
                catch (SqlException s)
                {
                    throw s;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion


        #region Delete


        public bool Eliminar(int id)
        {
            using (var n = dataContext.Database.BeginTransaction())
            {
                try
                {
                    var res = dbSet.Find(id);
                    if (res != null)
                    {
                        dbSet.Remove(res);
                        var save = dataContext.SaveChanges();
                        n.Commit();
                        return save > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException s)
                {
                    n.Rollback();
                    throw s;
                }
                catch (Exception e)
                {

                    return false;
                }
            }
        }

        public bool Eliminar(string id)
        {
            using (var n = dataContext.Database.BeginTransaction())
            {
                try
                {
                    var res = dbSet.Find(id);
                    if (res != null)
                    {
                        dbSet.Remove(res);
                        var save = dataContext.SaveChanges();
                        n.Commit();
                        return save > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException s)
                {
                    n.Rollback();
                    throw s;
                }
                catch (Exception e)
                {

                    return false;
                }
            }
        }

        public bool Eliminar(List<int> ids)
        {
            using (var n = dataContext.Database.BeginTransaction())
            {
                try
                {

                    foreach (var id in ids)
                    {
                        var res = dbSet.Find(id);
                        if (res != null)
                        {
                            dbSet.Remove(res);
                            var save = dataContext.SaveChanges();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    var savee = dataContext.SaveChanges();
                    n.Commit();
                    return savee > 0;

                }
                catch (SqlException s)
                {
                    n.Rollback();
                    throw s;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool Eliminar(IEnumerable<T> entities)
        {
            using (var tran = dataContext.Database.BeginTransaction())
            {
                try
                {
                    foreach (var item in entities)
                    {
                        var obj = dbSet.Find(item);
                        var del = dbSet.Remove(obj);
                    }
                    var ok = dataContext.SaveChanges();
                    tran.Commit();
                    return ok > 0;
                }
                catch (SqlException s)
                {
                    tran.Rollback();
                    return false;
                }
                catch (Exception e)
                {

                    return false;
                }
            }
        }

        #endregion

        #endregion

    }
}

