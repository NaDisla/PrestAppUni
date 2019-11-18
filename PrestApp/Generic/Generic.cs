using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient,

namespace PrestApp.Generic
{
    public class Generic<T> where T : class, new()
    {
        static string connectionString = @"data source=(localdb)\Server Local;initial catalog=DB_PrestApp;user id=sa_v2;password=nd-123456;Connect Timeout=60";

        public Generic()
        {
        }

        public static List<T> GetEntity()
        {
            List<T> Listado = new List<T>();
            string sql = "SELECT * FROM {0}";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T entity = new T()
                            {
                                ID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Salario = reader.GetDecimal(2)
                            };

                            listaEmpleados.Add(empleado);
                        }
                    }
                }

                con.Close();

                return listaEmpleados;
            }
        }
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
