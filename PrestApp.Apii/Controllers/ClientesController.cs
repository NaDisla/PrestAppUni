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
    public class ClientesController : ControllerBase
    {
        private ICRUDModel<ClClientes> generic = new CRUDModel<ClClientes>();
        private ICRUDModel<ClOcupaciones> dataOcupacion = new CRUDModel<ClOcupaciones>();
        private ICRUDModel<ClTitulosAcademicos> dataTitAcdm= new CRUDModel<ClTitulosAcademicos>();
        [Route("api/Clientes/Get")]
        [HttpGet]
        public ObjectResult ListClients()
        {
            try
            {
                var clients = generic.ObtenerTodos();
                foreach (var item in clients)
                {
                    item.Ocupacion = dataOcupacion.Obtener(item.Ocu_ID);
                    item.TituloAcademico = dataTitAcdm.Obtener(item.TitAcdm_ID);
                }
                return Ok(clients);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Clientes/Get/{id}")]
        [HttpGet]
        public ObjectResult GetUser(int id)
        {
            try
            {
                var clients = generic.Obtener(id);
                clients.Ocupacion = dataOcupacion.Obtener(clients.Ocu_ID);
                clients.TituloAcademico = dataTitAcdm.Obtener(clients.TitAcdm_ID);
                return Ok(clients);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Clientes/Insert")]
        [HttpPost]
        public ObjectResult Insert(ClClientes client)
        {
            try
            {
                var clients = generic.Insertar(client);
                return Ok(clients);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Clientes/Update")]
        [HttpPut]
        public ObjectResult Update(ClClientes client)
        {
            try
            {
                var clients = generic.Actualizar(client);
                return Ok(clients);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Clientes/Delete/{id}")]
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
