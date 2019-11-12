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
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClUsuario> generic = new Generic<ClUsuario>(rutaCompleta);
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
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClUsuario> generic = new Generic<ClUsuario>(rutaCompleta);
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
        public ObjectResult Insert(ClUsuario Rol)
        {
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClUsuario> generic = new Generic<ClUsuario>(rutaCompleta);
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
        public ObjectResult Update(ClUsuario Rol)
        {
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClUsuario> generic = new Generic<ClUsuario>(rutaCompleta);
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
        public ObjectResult Delete(ClUsuario id)
        {
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClUsuario> generic = new Generic<ClUsuario>(rutaCompleta);
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
