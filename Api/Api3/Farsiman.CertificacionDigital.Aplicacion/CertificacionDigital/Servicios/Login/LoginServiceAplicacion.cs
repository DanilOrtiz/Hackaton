using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Cifrado;
using Farsiman.CertificacionDigital.Aplicacion.Core;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios;
using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades = Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades;

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
            var usuario = _usuarioRepositorio.FirstOrDefault(x => x.CorreoElectronico == credenciales.Correo);
            var clave = _cifradoServicio.Cifrar(credenciales.Clave);

            string mensaje = string.Empty;

            if (!_loginServicioDominio.SonCredencialesValidas(usuario, clave, out mensaje))
            {
                credenciales.Respuesta = mensaje;
                credenciales.RespuestaTipo = RespuestaTipo.Validacion;
                return;
            }

            credenciales.Respuesta = "Bienvenido..!";
            credenciales.RespuestaTipo = RespuestaTipo.Ok;
        }

    
    }
}
