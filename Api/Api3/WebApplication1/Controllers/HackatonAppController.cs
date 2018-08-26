using Hackaton.Aplicacion.Core;
using Hackaton.Aplicacion.Hackaton.Servicios;
using Hackaton.Aplicacion.IoC;
using Hackaton.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api")]
    public class HackatonAppController : ApiController
    {
        IHackatonAppService hackatonService = Contenedor.Resolve<IHackatonAppService>();

        [HttpGet, Route("ObtenerSucesosValoracion")]
        public IHttpActionResult ObtenerSucesosValoracion()
        {
            var resultado = hackatonService.ObtenerSucesosValoracion();
            return Ok(resultado);
        }
        [HttpGet, Route("ObtenerSucesosMultimedia")]
        public IHttpActionResult ObtenerSucesosMultimedia()
        {
            var resultado = hackatonService.ObtenerSucesosMultimedia();
            return Ok(resultado);
        }
        [HttpGet, Route("ObtenerSucesosCategorias")]
        public IHttpActionResult ObtenerSucesosCategorias()
        {
            var resultado = hackatonService.ObtenerSucesosComentarios();
            return Ok(resultado);
        }
        [HttpGet, Route("ObtenerSucesosComentarios")]
        public IHttpActionResult ObtenerSucesosComentarios()
        {
            var resultado = hackatonService.ObtenerSucesosComentarios();
            return Ok(resultado);
        }
        [HttpGet, Route("ObtenerSucesos")]
        public IHttpActionResult ObtenerSucesos()
        {
            var resultado = hackatonService.ObtenerSucesos();
            return Ok(resultado);
        }

        [HttpPost, Route("crearsuceso")]
        public IHttpActionResult InsertarSuceso([FromBody]SucesoDto suceso)
        {
            var resultado = hackatonService.CrearSuceso(suceso);
            if (resultado.RespuestaTipo != RespuestaTipo.Ok)
                return BadRequest(resultado.Respuesta);
            return Ok(resultado);
        }

        [HttpGet, Route("InsertarValoracion/{sucesoId}/{valoracionId}/{usuarioId}")]
        public IHttpActionResult InsertarValoracion(int sucesoId, int valoracionId,int usuarioId)
        {
            return Ok(hackatonService.ValorarSuceso(sucesoId, valoracionId, usuarioId));
        }

    }
}