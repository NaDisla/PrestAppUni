using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Database.Models;
using PrestApp.Api.DataManagement.Generic;

namespace PrestApp.Apii.Controllers
{
    [Route("api/Roles")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private ICRUDModel<ClRoles> generic = new CRUDModel<ClRoles>();

        [Route("Get")]
        [HttpGet]
        public ObjectResult ListRoles()
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
        public ObjectResult GetRole(int id)
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
        public ObjectResult Insert(ClRoles Rol)
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
        public ObjectResult Update(ClRoles Rol)
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
        public ObjectResult Delete(ClRoles id)
        {
            try
            {
                var roles = generic.Eliminar(id.IDRol);
                return Ok(roles);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}