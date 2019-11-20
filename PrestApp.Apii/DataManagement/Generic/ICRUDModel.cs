using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.DataManagement.Generic
{
    public interface ICRUDModel<T> where T : class
    {
        IEnumerable<T> ObtenerTodos();
        T Obtener(int id);
        T Obtener(string id);
        bool Insertar(T entity);
        bool Insertar(List<T> entity);
        T AddGetObject(T entity);
        bool Actualizar(T nuevo);
        bool Actualizar(IEnumerable<T> nuevo);
        bool Eliminar(int id);
        bool Eliminar(List<int> ids);
        bool Eliminar(IEnumerable<T> entities);
    }
}
