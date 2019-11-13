using Microsoft.AspNetCore.Mvc;
using PrestApp.Clases;
using PrestApp.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.Controllers
{
    [Route("api/Clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public ObjectResult ListClients()
        {
            try
            {
                IGeneric<ClClientes> generic = new Generic<ClClientes>();
                var clients = generic.Get();
                return Ok(clients);
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
                IGeneric<ClClientes> generic = new Generic<ClClientes>();
                var clients = generic.Get(id);
                return Ok(clients);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Insert/{id}")]
        [HttpGet]
        public ObjectResult Insert(ClClientes client)
        {
            try
            {
                IGeneric<ClClientes> generic = new Generic<ClClientes>();
                var clients = generic.Insert(client);
                return Ok(clients);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Update")]
        [HttpGet]
        public ObjectResult Update(ClClientes client)
        {
            try
            {
                IGeneric<ClClientes> generic = new Generic<ClClientes>();
                var clients = generic.Update(client);
                return Ok(clients);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("Delete/{id}")]
        [HttpGet]
        public ObjectResult Delete(ClClientes id)
        {
            try
            {
                IGeneric<ClClientes> generic = new Generic<ClClientes>();
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
