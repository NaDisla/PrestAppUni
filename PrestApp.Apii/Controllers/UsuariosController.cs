using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Database;
using PrestApp.Api.DataManagement.Database.Models;
using PrestApp.Api.DataManagement.Generic;

namespace PrestApp.Api.Controllers
{
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private ICRUDModel<ClUsuarios> generic = new CRUDModel<ClUsuarios>();
        private ICRUDModel<ClRoles> dataRol = new CRUDModel<ClRoles>();

        [Route("api/Usuarios/Get")]
        [HttpGet]
        public ObjectResult ListUsers()
        {
            try
            {
                var Users = generic.ObtenerTodos();
                foreach (var item in Users)
                {
                    item.Rol = dataRol.Obtener(item.Rol_ID);
                }
                return Ok(Users);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Usuarios/Get/{id}")]
        [HttpGet]
        public ObjectResult GetUser(int id)
        {
            try
            {
                var user = generic.Obtener(id);
                user.Rol = dataRol.Obtener(user.Rol_ID);
                return Ok(user);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Usuarios/Insert")]
        [HttpPost]
        public ObjectResult Insert(ClUsuarios User)
        {
            try
            {
                User.Usu_Clave = Encoding.UTF8.GetBytes(User.Clave);
                var Success = generic.Insertar(User);
                return Ok(Success);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Usuarios/Update")]
        [HttpPut]
        public ObjectResult Update(ClUsuarios User)
        {
            try
            {
                User.Usu_Clave = Encoding.UTF8.GetBytes(User.Clave);
                var Success = generic.Actualizar(User);
                return Ok(Success);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Usuarios/Delete/{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            try
            {
                var Success = generic.Eliminar(id);
                return Ok(Success);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Usuarios/Login")]
        [HttpPost]
        public OkResult Login(LoginViewModel login)
        {
            try
            {
                using (var tran = new DB_PrestAppContext())
                {
                    byte[] Encrypted = Encoding.UTF8.GetBytes(login.passwd);
                    var success = tran.Set<ClUsuarios>().Select(x => x).Where(x => x.Usu_Nombre == login.user && x.Usu_Clave == Encrypted).FirstOrDefault();
                    if (success != null)
                    {
                        return Ok();
                    }
                    else
                    {
                        throw new Exception("Credenciales incorrectas.");
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
