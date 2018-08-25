using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Departamentos;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Departamentos;
using Farsiman.CertificacionDigital.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Farsiman.CertificacionDigital.Aplicacion.Core;


namespace WebApplication1.Controllers
{
    [RoutePrefix("api/certificacion/departamento")]
    public class DepartamentoController : ApiController
    {
        IDepartamentoAplicacionService departamentoServicio = Contenedor.Resolve<IDepartamentoAplicacionService>();

        [HttpGet]
        [Route("ObtenerDepartamentos")]
        public IHttpActionResult ObtenerDepartamentos()
        {
            var departamentos = departamentoServicio.ObtenerDepartamentosActivos();
            return Ok(departamentos);
        }

        [HttpPost]
        [Route("AgregarDepartamento")]
        public IHttpActionResult AgregarDepartamento(DepartamentoAgregarDto nuevoDepartamento)
        {
            departamentoServicio.AgregarDepartamento(nuevoDepartamento);

            if (nuevoDepartamento.RespuestaTipo != RespuestaTipo.Ok)
            {
                return BadRequest(nuevoDepartamento.Respuesta);
            }

            return Ok(nuevoDepartamento.Respuesta);

        }

        [HttpPost]
        [Route("EditarDepartamento")]
        public IHttpActionResult EditarDepartamento(DepartamentoEditDto departamentoEdit)
        {
            departamentoServicio.EditarDepartamento(departamentoEdit);

            if (departamentoEdit.RespuestaTipo != RespuestaTipo.Ok)
            {

                return BadRequest(departamentoEdit.Respuesta);
            }


            return Ok(departamentoEdit.Respuesta);
        }


    }
}
