using Microsoft.AspNetCore.Mvc;
using PrestApp.Clases;
using PrestApp.Generic;
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
        [Route("Get")]
        [HttpGet]
        public ObjectResult ListaPrestamos()
        {
            try
            {
                IGeneric<ClTitulosAcademicos> generic = new Generic<ClTitulosAcademicos>();
                var titulosAcademicos = generic.Get();
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
                IGeneric<ClTitulosAcademicos> generic = new Generic<ClTitulosAcademicos>();
                var tituloAcademico = generic.Get(id);
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
                IGeneric<ClTitulosAcademicos> generic = new Generic<ClTitulosAcademicos>();
                var result = generic.Insert(tituloAcademico);
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
                IGeneric<ClTitulosAcademicos> generic = new Generic<ClTitulosAcademicos>();
                var result = generic.Update(tituloAcademico);
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
                IGeneric<ClTitulosAcademicos> generic = new Generic<ClTitulosAcademicos>();
                var ok = generic.Delete(tituloAcademico);
                return Ok(ok);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
