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
        public ObjectResult ListaOcupaciones()
        {
            try
            {
                var ocupaciones = generic.ObtenerTodos();
                return Ok(ocupaciones);
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
                var ocupacion = generic.Obtener(id);
                return Ok(ocupacion);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Ocupaciones/Insert")]
        [HttpPost]
        public ObjectResult Insert(ClOcupaciones ocupacion)
        {
            try
            {
                var ocupaciones = generic.Insertar(ocupacion);
                return Ok(ocupaciones);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Ocupaciones/Update")]
        [HttpPut]
        public ObjectResult Update(ClOcupaciones ocupacion)
        {
            try
            {
                var ocupaciones = generic.Actualizar(ocupacion);
                return Ok(ocupacion);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/Ocupaciones/Delete")]
        [HttpDelete]
        public ObjectResult Delete(ClOcupaciones id)
        {
            try
            {
                var ok = generic.Eliminar(id.IDOcu);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}

