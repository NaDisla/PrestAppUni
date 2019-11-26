using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrestApp.Api.DataManagement.Generic;
using PrestApp.Api.DataManagement.Database.Models;

namespace PrestApp.Api.Controllers
{
    [ApiController]
    public class AmortizacionesController : ControllerBase
    {
        private ICRUDModel<ClAmortizaciones> generic = new CRUDModel<ClAmortizaciones>();
        private ICRUDModel<ClClientes> dataClietne = new CRUDModel<ClClientes>();
        private ICRUDModel<ClPrestamos> dataPrestamo = new CRUDModel<ClPrestamos>();
        private ICRUDModel<ClModalidadesDePago> dataModPago = new CRUDModel<ClModalidadesDePago>();

        [Route("api/Amortizaciones/Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                var Amortizaciones = generic.ObtenerTodos();
                foreach (var item in Amortizaciones)
                {
                    item.Clientes = dataClietne.Obtener(item.Cli_ID);
                    item.Prestamo = dataPrestamo.Obtener(item.Prest_ID);
                    item.ClModalidadesDePago = dataModPago.Obtener(item.ModPag_ID);
                }
                return Ok(Amortizaciones);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Amortizaciones/Get/{id}")]
        [HttpGet]
        public ObjectResult GetUser(int id)
        {
            try
            {
                var pago = generic.Obtener(id);
                pago.Clientes = dataClietne.Obtener(pago.Cli_ID);
                pago.Prestamo = dataPrestamo.Obtener(pago.Prest_ID);
                pago.ClModalidadesDePago = dataModPago.Obtener(pago.ModPag_ID);
                return Ok(pago);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Amortizaciones/Insert")]
        [HttpPost]
        public ObjectResult Insert(ClAmortizaciones pago)
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

        [Route("api/Amortizaciones/Update")]
        [HttpPut]
        public ObjectResult Update(ClAmortizaciones pago)
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

        [Route("api/Amortizaciones/Delete")]
        [HttpDelete]
        public ObjectResult Delete(ClAmortizaciones id)
        {
            try
            {
                var ok = generic.Eliminar(id.Amort_ID);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
