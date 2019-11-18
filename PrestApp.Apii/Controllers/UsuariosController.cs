using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Database;
using PrestApp.Api.DataManagement.Database.Models;
using PrestApp.Api.DataManagement.Generic;

namespace PrestApp.Api.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuariosController : ControllerBase
    {
        private ICRUDModel<ClUsuarios> generic = new CRUDModel<ClUsuarios>();

        [Route("Get")]
        [HttpGet]
        public ObjectResult ListUsers()
        {
            try
            {
                var Users = generic.ObtenerTodos();
                return Ok(Users);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Get/{id}")]
        [HttpGet]
        public ObjectResult GetUser(int id)
        {
            try
            {
                var user = generic.Obtener(id);
                return Ok(user);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Insert/{id}")]
        [HttpGet]
        public ObjectResult Insert(ClUsuarios Rol)
        {
            try
            {
                var Success = generic.Insertar(Rol);
                return Ok(Success);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Update")]
        [HttpGet]
        public ObjectResult Update(ClUsuarios Rol)
        {
            try
            {
                var Success = generic.Actualizar(Rol);
                return Ok(Success);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Delete/{id}")]
        [HttpGet]
        public ObjectResult Delete(ClUsuarios id)
        {
            try
            {
                var Success = generic.Eliminar(id.Usu_ID);
                return Ok(Success);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Login")]
        [HttpPost]
        public OkResult Login(string User, string Password)
        {
            try
            {
                using (var tran = new DB_PrestAppContext())
                {
                    var success = tran.Set<ClUsuarios>().Select(x => x).Where(x => x.Usu_Nombre == User && x.Usu_Pass == Password).FirstOrDefault();
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
