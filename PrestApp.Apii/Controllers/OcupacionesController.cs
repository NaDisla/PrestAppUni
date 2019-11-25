using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Database.Models;
using PrestApp.Api.DataManagement.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.Controllers
{
    [ApiController]
    public class OcupacionesController : ControllerBase
    {
        ICRUDModel<ClOcupaciones> generic = new CRUDModel<ClOcupaciones>();

        [Route("api/Ocupaciones/Get")]
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

        [Route("api/Ocupaciones/Get/{id}")]
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

        [Route("api/Ocupaciones/Insert")]
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

        [Route("api/Ocupaciones/Update")]
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

        [Route("api/Ocupaciones/Delete")]
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

