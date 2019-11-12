using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PrestApp.Generic
{
    public interface IGeneric<T> where T: class, new()
    {
        List<T> Get();
        T Get(int id);
        List<T> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null);
        T Get(Expression<Func<T, bool>> predicate);
        TableQuery<T> AsQueryable();
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        
    }
}
