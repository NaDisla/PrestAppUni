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
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>();
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
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>();
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
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>();
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
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>();
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
            try
            {
                IGeneric<ClPrestamos> generic = new Generic<ClPrestamos>();
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
