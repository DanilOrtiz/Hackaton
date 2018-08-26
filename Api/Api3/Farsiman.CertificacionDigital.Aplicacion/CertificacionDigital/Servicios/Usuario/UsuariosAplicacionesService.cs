using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Cifrado;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital
{
    public class UsuariosAplicacionesService : IUsuarioAplicacionService
    {
        private readonly IRepositorio<Usuario> _usuarioRepositorio;
        private readonly ICifradoServicio _cigradoAplicacionServicio;

        public UsuariosAplicacionesService(IRepositorio<Usuario> usuarioRepositorio,
                                           ICifradoServicio cifradoAplicacionServicio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _cigradoAplicacionServicio = cifradoAplicacionServicio;

        }


        public void AgregarUsuario(UsuarioAgregarDto usuarioNuevo)
        {
            var usuario = usuarioNuevo.MapTo<Usuario>();
            usuario.Clave = _cigradoAplicacionServicio.Cifrar(usuarioNuevo.Clave);

            string mensaje = "";

            if (!usuario.EsValido(ref mensaje))
            {

                usuarioNuevo.Respuesta = mensaje;
                return;
            }
            _usuarioRepositorio.Agregar(usuario);
            _usuarioRepositorio.UnitOfWork.Commit();

        }

        public List<UsuarioDto> ObtenerUsuariosActivos()
        {
            var usuarios = _usuarioRepositorio.ObtenerTodos();

            return (from u in usuarios
                    select new UsuarioDto
                    {
                        Email = u.CorreoElectronico,
                        NombreCompleto = u.Nombre + " " + u.Apellido,
                        Id = u.Id,
                        Clave = u.Clave,
                        CodigoColaborador = u.CodigoColaborador,
                        CorreoElectronico = u.CorreoElectronico,
                        PerfilId = u.PerfilId
                    }).ToList();
        }

        public List<UsuarioConPerilDto> ObtenerUsuariosProgramadores()
        {
            return (from u in _usuarioRepositorio.AsQueryable()
                    where u.PerfilId == 2
                    select new UsuarioConPerilDto
                    {
                        Id = u.Id,
                        NombreCompleto = u.Nombre + " " + u.Apellido,
                        //Perfil = u.Perfil.Descripcion,

                    }).ToList();
        }

        public void EditarUsuario(UsuarioEditDto usuarioEdit)
        {
            var usuario = (from u in _usuarioRepositorio.AsQueryable()
                           where u.Id == usuarioEdit.Id
                           select u).FirstOrDefault();

            usuario.Nombre = usuarioEdit.Nombre;
            usuario.Apellido = usuarioEdit.Apellido;
            usuario.Clave = _cigradoAplicacionServicio.Cifrar(usuarioEdit.Clave);
            usuario.CodigoColaborador = usuarioEdit.CodigoColaborador;
            usuario.CorreoElectronico = usuarioEdit.CorreoElectronico;
            usuario.Activo = usuarioEdit.Activo;
            usuario.PerfilId = usuarioEdit.PerfilId;

            string mensaje = "";

            if (!usuario.EsValido(ref mensaje))
            {
                usuarioEdit.Respuesta = mensaje;
                usuarioEdit.RespuestaTipo = Core.RespuestaTipo.Validacion;
                return;
            }


            _usuarioRepositorio.UnitOfWork.Commit();
            usuarioEdit.Respuesta = "ok";
            usuarioEdit.RespuestaTipo = Core.RespuestaTipo.Ok;
        }
    }
}
