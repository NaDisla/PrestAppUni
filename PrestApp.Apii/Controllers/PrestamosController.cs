using Microsoft.AspNetCore.Mvc;
using PrestApp.Clases;
using PrestApp.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.Controllers
{
    [Route("api/Prestamos")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>(rutaCompleta);
                var prestamos = generic.Get();
                return Ok(prestamos);
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
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>(rutaCompleta);
                var prestamo = generic.Get(id);
                return Ok(prestamo);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Insert/{id}")]
        [HttpGet]
        public ObjectResult Insert(ClPrestamos client)
        {
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>(rutaCompleta);
                var prestamo = generic.Insert(client);
                return Ok(prestamo);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Update")]
        [HttpGet]
        public ObjectResult Update(ClPrestamos client)
        {
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>(rutaCompleta);
                var prestamo = generic.Update(client);
                return Ok(prestamo);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Delete/{id}")]
        [HttpGet]
        public ObjectResult Delete(ClPrestamos id)
        {
            string nombreArchivo = "BD_PrestApp.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>(rutaCompleta);
                var ok = generic.Delete(id);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
