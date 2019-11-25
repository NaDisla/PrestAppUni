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
    public class ModalidadesPagoController : ControllerBase
    {
        ICRUDModel<ClModalidadesDePago> generic = new CRUDModel<ClModalidadesDePago>();

        [Route("api/ModalidadesDePago/Get")]
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

        [Route("api/ModalidadesDePago/Get/{id}")]
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

        [Route("api/ModalidadesDePago/Insert")]
        [HttpPost]
        public ObjectResult Insert(ClModalidadesDePago pago)
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

        [Route("api/ModalidadesDePago/Update")]
        [HttpPut]
        public ObjectResult Update(ClModalidadesDePago pago)
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

        [Route("api/ModalidadesDePago/Delete")]
        [HttpDelete]
        public ObjectResult Delete(ClModalidadesDePago id)
        {
            try
            {
                var ok = generic.Eliminar(id.ModPag_ID);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
