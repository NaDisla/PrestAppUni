using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestApp.Clases;
using PrestApp.Generic;

namespace PrestApp.Api.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuariosController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public ObjectResult ListUsers()
        {
            try
            {
                IGeneric<ClUsuarios> generic = new Generic<ClUsuarios>();
                var roles = generic.Get();
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
                IGeneric<ClUsuarios> generic = new Generic<ClUsuarios>();
                var roles = generic.Get(id);
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
                IGeneric<ClUsuarios> generic = new Generic<ClUsuarios>();
                var roles = generic.Insert(Rol);
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
                IGeneric<ClUsuarios> generic = new Generic<ClUsuarios>();
                var roles = generic.Update(Rol);
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
                IGeneric<ClUsuarios> generic = new Generic<ClUsuarios>();
                var roles = generic.Delete(id);
                return Ok(roles);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
