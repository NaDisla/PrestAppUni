using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrestApp.Generic
{
    public class Generic<T> : IGeneric<T> where T : class, new()
    {
        protected SQLiteConnection db;

        public Generic(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<T>();
        }

        public TableQuery<T> AsQueryable() =>
            db.Table<T>();

        public List<T> Get() =>
             db.Table<T>().ToList();

        public List<T> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null)
        {
            var query = db.Table<T>();

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                query = query.OrderBy<TValue>(orderBy);

            return query.ToList();
        }

        public T Get(int id) =>
              db.Find<T>(id);

        public T Get(Expression<Func<T, bool>> predicate) =>
            db.Find<T>(predicate);

        public int Insert(T entity) =>
              db.Insert(entity);

        public int Update(T entity) =>
             db.Update(entity);

        public int Delete(T entity) =>
            db.Delete(entity);
    }
}
