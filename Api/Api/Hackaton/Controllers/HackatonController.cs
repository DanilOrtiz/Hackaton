using Hackaton.App_Start;
using Hackaton.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hackaton.Controllers
{
    [RoutePrefix("api")]
    public class HackatonController : ApiController
    {
        private IHackatonService _hackatonService = Contenedor.Resolve<IHackatonService>();


        [HttpGet]
        [Route("ObtenerCategorias")]
        public IHttpActionResult ObtenerCategorias()
        {
            var categorias = _hackatonService.ObtenerCategorias();
            return Ok(categorias);
        }


    }
}
