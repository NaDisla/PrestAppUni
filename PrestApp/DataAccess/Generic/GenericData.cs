using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PrestApp.Generic
{
    public class GenericData<T> : IGenericData<T> where T : class, new()
    {
        private SQLiteAsyncConnection db;

        public GenericData(SQLiteAsyncConnection db)
        {
            this.db = db;
        }

        public AsyncTableQuery<T> AsQueryable() =>
            db.Table<T>();

        public async Task<List<T>> Get() =>
            await db.Table<T>().ToListAsync();

        public async Task<List<T>> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null)
        {
            try
            {
                var query = db.Table<T>();

                if (predicate != null)
                    query = query.Where(predicate);

                if (orderBy != null)
                    query = query.OrderBy<TValue>(orderBy);

                return await query.ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public async Task<T> Get(int id)
        {
            try
            {
                return await db.FindAsync<T>(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await db.FindAsync<T>(predicate);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<int> Insert(T entity)
        {
            try
            {
                return await db.InsertAsync(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<int> Update(T entity)
        {
            try
            {
                return await db.UpdateAsync(entity);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<int> Delete(T entity)
        {
            try
            {
                return await db.DeleteAsync(entity);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
