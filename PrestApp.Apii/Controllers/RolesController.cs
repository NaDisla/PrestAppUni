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
    [ApiController]
    public class RolesController : ControllerBase
    {
        private ICRUDModel<ClRoles> generic = new CRUDModel<ClRoles>();

        [Route("api/Roles/Get")]
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

        [Route("api/Roles/Get/{id}")]
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

        [Route("api/Roles/Insert/{id}")]
        [HttpPost]
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

        [Route("api/Roles/Update")]
        [HttpPut]
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

        [Route("api/Roles/Delete/{id}")]
        [HttpDelete]
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