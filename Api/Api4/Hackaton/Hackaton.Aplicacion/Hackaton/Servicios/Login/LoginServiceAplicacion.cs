using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Cifrado;
using Hackaton.Aplicacion.Core;
using Hackaton.Aplicacion.Hackaton.Dtos.Usuarios;
using Hackaton.Aplicacion.Hackaton.Servicios.Login;
using Hackaton.Domain.Entities;
using Hackaton.Dominio.Core.Repositorios;
using Hackaton.Dominio.Hackaton.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Login
{
    public class LoginServiceAplicacion : ILoginServiceAplicacion
    {
        private readonly ILoginServiceDominio _loginServicioDominio;
        private readonly IRepositorio<Usuario> _usuarioRepositorio;
        private readonly ICifradoServicio _cifradoServicio;


        public LoginServiceAplicacion(ILoginServiceDominio loginServicioDominio,
            ICifradoServicio cifradoServicio,
            IRepositorio<Usuario> usuarioRepositorio)
        {
            _loginServicioDominio = loginServicioDominio;
            _usuarioRepositorio = usuarioRepositorio;
            _cifradoServicio = cifradoServicio;
        }


        public void SonCredencialesValidas(UsuarioLoginDto credenciales)
        {
            var usuario = _usuarioRepositorio.FirstOrDefault(x => x.Correo == credenciales.Correo);
            var clave = _cifradoServicio.Cifrar(credenciales.Clave);

            string mensaje = string.Empty;

            if (!_loginServicioDominio.SonCredencialesValidas(usuario, clave, out mensaje))
            {
                credenciales.Respuesta = mensaje;
                credenciales.RespuestaTipo = RespuestaTipo.Validacion;
                return;
            }

            credenciales.UsuarioId = usuario.Id;
            credenciales.Respuesta = "Bienvenido..!";
            credenciales.RespuestaTipo = RespuestaTipo.Ok;
        }

    
    }
}
