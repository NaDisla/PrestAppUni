using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestApp.Clases;
using PrestApp.Generic;

namespace PrestApp.Apii.Controllers
{
    [Route("api/Roles")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public ObjectResult ListRoles()
        {
            try
            {
                IGeneric<Roles> generic = new Generic<Roles>();
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
        public ObjectResult GetRole(int id)
        {
            try
            {
                IGeneric<Roles> generic = new Generic<Roles>();
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
        public ObjectResult Insert(Roles Rol)
        {
            try
            {
                IGeneric<Roles> generic = new Generic<Roles>();
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
        public ObjectResult Update(Roles Rol)
        {
            try
            {
                IGeneric<Roles> generic = new Generic<Roles>();
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
        public ObjectResult Delete(Roles id)
        {
            try
            {
                IGeneric<Roles> generic = new Generic<Roles>();
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