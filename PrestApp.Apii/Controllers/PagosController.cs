using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Database.Models;
using PrestApp.Api.DataManagement.Generic;


namespace PrestApp.Api.Controllers
{
    [ApiController]
    public class PagosController : ControllerBase
    {

        ICRUDModel<ClPagos> generic = new CRUDModel<ClPagos>();
        ICRUDModel<ClClientes> dataCliente= new CRUDModel<ClClientes>();
        ICRUDModel<ClTitulosAcademicos> datatitulo = new CRUDModel<ClTitulosAcademicos>();
        ICRUDModel<ClOcupaciones> dataOcupacion = new CRUDModel<ClOcupaciones>();

        [Route("api/Pagos/Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                var pagos = generic.ObtenerTodos();
                foreach (var item in pagos)
                {
                    item.ClCliente = dataCliente.Obtener(item.Cli_ID);
                    item.ClCliente.TituloAcademico = datatitulo.Obtener(item.ClCliente.TitAcdm_ID);
                    item.ClCliente.Ocupacion = dataOcupacion.Obtener(item.ClCliente.Ocu_ID);
                }
                return Ok(pagos);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Pagos/Get/{id}")]
        [HttpGet]
        public ObjectResult GetUser(int id)
        {
            try
            {
                var pago = generic.Obtener(id);
                pago.ClCliente = dataCliente.Obtener(pago.Cli_ID);
                pago.ClCliente.TituloAcademico = datatitulo.Obtener(pago.ClCliente.TitAcdm_ID);
                pago.ClCliente.Ocupacion = dataOcupacion.Obtener(pago.ClCliente.Ocu_ID);
                return Ok(pago);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Pagos/Insert")]
        [HttpPost]
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

        [Route("api/Pagos/Update")]
        [HttpPut]
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

        [Route("api/Pagos/Delete")]
        [HttpDelete]
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
