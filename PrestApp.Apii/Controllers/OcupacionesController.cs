using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Generic;
using PrestApp.Clases;
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
        ICRUDModel<ClOcupaciones> generic = new CRUDModel<ClOcupaciones>();

        [Route("Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                var pagos = generic.ObtenerTodos();
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
                var pago = generic.Obtener(id);
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
                var pagos = generic.Insertar(pago);
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
                var prestamo = generic.Actualizar(pago);
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
                var ok = generic.Eliminar(id.Ocu_ID);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}

