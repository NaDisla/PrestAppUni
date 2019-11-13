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
    [Route("api/Pagos")]
    [ApiController]
    public class PagosController : ControllerBase
    {

        [Route("Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                IGeneric<ClPagos> generic = new Generic<ClPagos>();
                var pagos = generic.Get();
                return Ok(pagos );
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
                IGeneric<ClPagos> generic = new Generic<ClPagos>();
                var pago = generic.Get(id);
                return Ok(pago);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Insert")]
        [HttpGet]
        public ObjectResult Insert(ClPagos pago)
        {
            try
            {
                IGeneric<ClPagos> generic = new Generic<ClPagos>();
                var pagos = generic.Insert(pago);
                return Ok(pagos);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Update")]
        [HttpGet]
        public ObjectResult Update(ClPagos pago)
        {
            try
            {
                IGeneric<ClPagos> generic = new Generic<ClPagos>();
                var prestamo = generic.Update(pago);
                return Ok(prestamo);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Delete")]
        [HttpGet]
        public ObjectResult Delete(ClPagos id)
        {
            try
            {
                IGeneric<ClPagos> generic = new Generic<ClPagos>();
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
