using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Database.Models;
using PrestApp.Api.DataManagement.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.Controllers
{
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        private ICRUDModel<ClPrestamos> generic = new CRUDModel<ClPrestamos>();
        private ICRUDModel<ClClientes> dataCliente= new CRUDModel<ClClientes>();
        private ICRUDModel<ClOcupaciones> dataOcupacion = new CRUDModel<ClOcupaciones>();
        private ICRUDModel<ClTitulosAcademicos> dataTitAcdm = new CRUDModel<ClTitulosAcademicos>();
        
        [Route("api/Prestamos/Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                var prestamos = generic.ObtenerTodos();
                foreach (var item in prestamos)
                {
                    item.Cliente = dataCliente.Obtener(item.Cli_ID);
                    item.Cliente.TituloAcademico = dataTitAcdm.Obtener(item.Cliente.TitAcdm_ID);
                    item.Cliente.Ocupacion = dataOcupacion.Obtener(item.Cliente.Ocu_ID);
                }
                return Ok(prestamos);
            }
            catch (Exception e)
            {

                throw e.InnerException ?? e;
            }
        }

        [Route("api/Prestamos/Get/{id}")]
        [HttpGet]
        public ObjectResult GetUser(int id)
        {
            try
            {
                var prestamo = generic.Obtener(id);
                prestamo.Cliente = dataCliente.Obtener(prestamo.Cli_ID);
                prestamo.Cliente.TituloAcademico = dataTitAcdm.Obtener(prestamo.Cliente.TitAcdm_ID);
                prestamo.Cliente.Ocupacion = dataOcupacion.Obtener(prestamo.Cliente.Ocu_ID);
                return Ok(prestamo);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Prestamos/Insert")]
        [HttpPost]
        public ObjectResult Insert(ClPrestamos client)
        {
            try
            {
                var prestamo = generic.Insertar(client);
                return Ok(prestamo);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Prestamos/Update")]
        [HttpPut]
        public ObjectResult Update(ClPrestamos client)
        {
            try
            {
                var prestamo = generic.Actualizar(client);
                return Ok(prestamo);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Prestamos/Delete/{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            try
            {
                var ok = generic.Eliminar(id);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
