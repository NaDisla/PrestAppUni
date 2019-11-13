using Microsoft.AspNetCore.Mvc;
using PrestApp.Clases;
using PrestApp.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.Controllers
{
    [Route("api/ModalidadesDePago")]
    [ApiController]
    public class ModalidadesPagoController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                IGeneric<ClModalidadesDePago> generic = new Generic<ClModalidadesDePago>();
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
                IGeneric<ClModalidadesDePago> generic = new Generic<ClModalidadesDePago>();
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
        public ObjectResult Insert(ClModalidadesDePago pago)
        {
            try
            {
                IGeneric<ClModalidadesDePago> generic = new Generic<ClModalidadesDePago>();
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
        public ObjectResult Update(ClModalidadesDePago pago)
        {
            try
            {
                IGeneric<ClModalidadesDePago> generic = new Generic<ClModalidadesDePago>();
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
        public ObjectResult Delete(ClModalidadesDePago id)
        {
            try
            {
                IGeneric<ClModalidadesDePago> generic = new Generic<ClModalidadesDePago>();
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
