using Hackaton.Application.IoC;
using Hackaton.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api")]
    public class DepartamentoController : ApiController
    {
        IHackatonService hackatonService = Contenedor.Resolve<IHackatonService>();
        //IDepartamentoAplicacionService departamentoServicio = Contenedor.Resolve<IDepartamentoAplicacionService>();


        [HttpGet]
        [Route("ObtenerCategorias")]
        public IHttpActionResult ObtenerDepartamentos()
        {
            var departamentos = hackatonService.ObtenerCategorias();
            return Ok(departamentos);
        }

        //[HttpPost]
        //[Route("AgregarDepartamento")]
        //public IHttpActionResult AgregarDepartamento(DepartamentoAgregarDto nuevoDepartamento)
        //{
        //    departamentoServicio.AgregarDepartamento(nuevoDepartamento);

        //    if (nuevoDepartamento.RespuestaTipo != RespuestaTipo.Ok)
        //    {
        //        return BadRequest(nuevoDepartamento.Respuesta);
        //    }

        //    return Ok(nuevoDepartamento.Respuesta);

        //}

        //[HttpPost]
        //[Route("EditarDepartamento")]
        //public IHttpActionResult EditarDepartamento(DepartamentoEditDto departamentoEdit)
        //{
        //    departamentoServicio.EditarDepartamento(departamentoEdit);

        //    if (departamentoEdit.RespuestaTipo != RespuestaTipo.Ok)
        //    {

        //        return BadRequest(departamentoEdit.Respuesta);
        //    }


        //    return Ok(departamentoEdit.Respuesta);
        //}


    }
}
