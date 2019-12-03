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
        [Route("api/Clientes/Get")]
        [HttpGet]
        public ObjectResult ListClients()
        {
            try
            {
                var clients = generic.ObtenerTodos();
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

        [Route("api/Clientes/Delete")]
        [HttpDelete]
        public ObjectResult Delete(ClClientes id)
        {
            try
            {
                var ok = generic.Eliminar(id.IDCli);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
