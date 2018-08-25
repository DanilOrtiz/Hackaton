using Hackaton.Aplicacion.IoC;
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
    public class HackatonController : ApiController
    {
        IHackatonService hackatonService =  Contenedor.Resolve<IHackatonService>();
       

        [HttpGet]
        [Route("ObtenerCategorias")]
        public IHttpActionResult ObtenerCategorias()
        {
            var categorias = hackatonService.ObtenerCategorias();
            return Ok(categorias);
        }

        [HttpGet]
        [Route("ObtenerCiudades")]
        public IHttpActionResult ObtenerCiudades()
        {
            var ciudades = hackatonService.ObtenerCiudades();
            return Ok(ciudades);
        }

        [HttpGet]
        [Route("ObtenerEmpresas")]
        public IHttpActionResult ObtenerEmpresas()
        {
            var empresas = hackatonService.ObtenerEmpresas();
            return Ok(empresas);
        }

        [HttpGet]
        [Route("ObtenerEmpresasCategoria")]
        public IHttpActionResult ObtenerEmpresasCategoria()
        {
            var empresasCategoria = hackatonService.ObtenerEmpresasPorCategoria();
            return Ok(empresasCategoria);
        }


        [HttpGet]
        [Route("ObtenerEstados")]
        public IHttpActionResult ObtenerEstados()
        {
            var estados = hackatonService.ObtenerEstados();
            return Ok(estados);
        }

        [HttpGet]
        [Route("ObtenerPerfiles")]
        public IHttpActionResult ObtenerPerfiles()
        {
            var perfiles = hackatonService.ObtenerPerfiles();
            return Ok(perfiles);
        }

        [HttpPost]
        [Route("ObtenerTopDeSuceso")]
        public IHttpActionResult ObtenerTopDeSuceso(int top)
        {
            var sucesos = hackatonService.ObtenerTopDeSucesos(top);
            return Ok(sucesos);
        }

        [Route("ObtenerTopDeSucesosMenorDeId/{top}/{sucesoId}")]
        [HttpPost]
        public IHttpActionResult ObtenerTopDeSucesosMenorDeId(int top, int sucesoId)
        {
            var sucesos = hackatonService.ObtenerTopDeSucesosMenorDeId(top, sucesoId);
            return Ok(sucesos);
        }
    }
}
