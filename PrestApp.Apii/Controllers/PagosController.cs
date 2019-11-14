using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Generic;
using PrestApp.Clases;


namespace PrestApp.Api.Controllers
{
    [Route("api/Pagos")]
    [ApiController]
    public class PagosController : ControllerBase
    {

        ICRUDModel<ClPagos> generic = new CRUDModel<ClPagos>();

        [Route("Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                var pagos = generic.ObtenerTodos();
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
        public ObjectResult Insert(ClPagos pago)
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
        public ObjectResult Update(ClPagos pago)
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
        public ObjectResult Delete(ClPagos id)
        {
            try
            {
                var ok = generic.Eliminar(id.Pag_ID);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
