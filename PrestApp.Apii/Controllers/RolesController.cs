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
        [Route("Index")]
        [HttpGet]
        public ObjectResult ListRoles()
        {
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<Roles> generic = new Generic<Roles>(rutaCompleta);
                var roles = generic.Get();                
                return Ok(roles);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}