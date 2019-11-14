using Microsoft.AspNetCore.Mvc;
using PrestApp.Api.DataManagement.Generic;
using PrestApp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestApp.Api.Controllers
{
    [ApiController]
    [Route("api/TitulosAcademicos")]
    public class TitulosAcademicosController : ControllerBase
    {
        private ICRUDModel<ClTitulosAcademicos> generic = new CRUDModel<ClTitulosAcademicos>();

        [Route("Get")]
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

        [Route("Get/{id}")]
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

        [Route("Insert")]
        [HttpGet]
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

        [Route("Update")]
        [HttpGet]
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

        [Route("Delete")]
        [HttpGet]
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
