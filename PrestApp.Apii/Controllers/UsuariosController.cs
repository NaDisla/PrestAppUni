using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Generic;
using PrestApp.Clases;

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
                var roles = generic.ObtenerTodos();
                return Ok(roles);
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
                var roles = generic.Obtener(id);
                return Ok(roles);
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
                var roles = generic.Insertar(Rol);
                return Ok(roles);
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
                var roles = generic.Actualizar(Rol);
                return Ok(roles);
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
                var roles = generic.Eliminar(id.Usu_ID);
                return Ok(roles);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
