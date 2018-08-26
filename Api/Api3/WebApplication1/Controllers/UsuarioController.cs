using Hackaton.Aplicacion.Hackaton.Dtos.Usuarios;
using Hackaton.Aplicacion.Hackaton.Servicios.Login;
using Hackaton.Aplicacion.IoC;
using Hackaton.Application.Dtos;
using Hackaton.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        ILoginServiceAplicacion loginAppService = Contenedor.Resolve<ILoginServiceAplicacion>();
        IHackatonService hackatonService = Contenedor.Resolve<IHackatonService>();

        [HttpPost]
        [Route("CrearUsuario")]
        public IHttpActionResult CrearUsuario(UsuarioDto nuevoUsuario)
        {
            var usuario = hackatonService.AgregarUsuario(nuevoUsuario);
            return Ok(usuario);
        }

        [HttpPost]
        [Route("ValidarCredenciales")]
        public IHttpActionResult ValidarCredenciales(UsuarioLoginDto credenciales)
        {
            loginAppService.SonCredencialesValidas(credenciales);
            return Ok(credenciales);
        }
        [HttpGet]
        [Route("UsuarioPorId/{usuarioID}")]
        public IHttpActionResult ValidarCredenciales(int usuarioID)
        {
            var resultado = hackatonService.ObtenerUsuarioPorId(usuarioID);
            return Ok(resultado);
        }

    }
}
