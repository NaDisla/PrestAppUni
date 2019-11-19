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
    public class TitulosAcademicosController : ControllerBase
    {
        private ICRUDModel<ClTitulosAcademicos> generic = new CRUDModel<ClTitulosAcademicos>();

        [Route("api/TitulosAcademicos/Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                var titulosAcademicos = generic.ObtenerTodos();
                return Ok(titulosAcademicos);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/TitulosAcademicos/Get/{id}")]
        [HttpGet]
        public ObjectResult GetUser(int id)
        {
            try
            {
                var tituloAcademico = generic.Obtener(id);
                return Ok(tituloAcademico);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/TitulosAcademicos/Insert")]
        [HttpPost]
        public ObjectResult Insert(ClTitulosAcademicos tituloAcademico)
        {
            try
            {
                var result = generic.Insertar(tituloAcademico);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/TitulosAcademicos/Update")]
        [HttpPut]
        public ObjectResult Update(ClTitulosAcademicos tituloAcademico)
        {
            try
            {
                var result = generic.Actualizar(tituloAcademico);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("api/TitulosAcademicos/Delete")]
        [HttpDelete]
        public ObjectResult Delete(ClTitulosAcademicos tituloAcademico)
        {
            try
            {
                var ok = generic.Eliminar(tituloAcademico.TitAcdm_ID);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
