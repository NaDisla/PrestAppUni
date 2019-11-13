using Microsoft.AspNetCore.Mvc;
using PrestApp.Clases;
using PrestApp.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.Controllers
{
    [Route("api/Amortizaciones")]
    [ApiController]
    public class AmortizacionesController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                IGeneric<ClAmortizaciones> generic = new Generic<ClAmortizaciones>();
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
                IGeneric<ClAmortizaciones> generic = new Generic<ClAmortizaciones>();
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
        public ObjectResult Insert(ClAmortizaciones pago)
        {
            try
            {
                IGeneric<ClAmortizaciones> generic = new Generic<ClAmortizaciones>();
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
        public ObjectResult Update(ClAmortizaciones pago)
        {
            try
            {
                IGeneric<ClAmortizaciones> generic = new Generic<ClAmortizaciones>();
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
        public ObjectResult Delete(ClAmortizaciones id)
        {
            try
            {
                IGeneric<ClAmortizaciones> generic = new Generic<ClAmortizaciones>();
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
