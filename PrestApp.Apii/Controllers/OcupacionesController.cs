using Microsoft.AspNetCore.Mvc;
using PrestApp.Clases;
using PrestApp.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.Controllers
{
    [Route("api/Ocupaciones")]
    [ApiController]
    public class OcupacionesController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                IGeneric<ClOcupaciones> generic = new Generic<ClOcupaciones>();
                var pagos = generic.Get();
                return Ok(pagos);
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
                IGeneric<ClOcupaciones> generic = new Generic<ClOcupaciones>();
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
        public ObjectResult Insert(ClOcupaciones pago)
        {
            try
            {
                IGeneric<ClOcupaciones> generic = new Generic<ClOcupaciones>();
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
        public ObjectResult Update(ClOcupaciones pago)
        {
            try
            {
                IGeneric<ClOcupaciones> generic = new Generic<ClOcupaciones>();
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
        public ObjectResult Delete(ClOcupaciones id)
        {
            try
            {
                IGeneric<ClOcupaciones> generic = new Generic<ClOcupaciones>();
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

