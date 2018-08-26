using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hackaton.Application.Dtos;
using Hackaton.Domain.Entities;
using Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Cifrado;
using Farsiman.CertificacionDigital.Aplicacion.Core;
using Hackaton.Dominio.Core.Repositorios;

namespace Hackaton.Application.Services
{
    public class HackatonService : IHackatonService
    {

        private readonly IRepositorio<Ciudad> _ciudadRepositorio;
        private readonly IRepositorio<Categoria> _categoriaRepositorio;
        private readonly IRepositorio<Empresa> _empresaRepositorio;
        private readonly IRepositorio<EmpresaCategoria> _empresaCategoriaRepositorio;
        private readonly IRepositorio<Estado> _estadoRepositorio;
        private readonly IRepositorio<Perfil> _perfilRepositorio;
        private readonly IRepositorio<Usuario> _usuarioRepositorio;
        private readonly ICifradoServicio _cigradoAplicacionServicio;


        public HackatonService(IRepositorio<Ciudad> ciudadRepositorio
            ,IRepositorio<Categoria> categoriaRepositorio
            , IRepositorio<Empresa> empresaRepositorio
            , IRepositorio<EmpresaCategoria> empresaCategoriaRepositorio
            , IRepositorio<Estado> estadoRepositorio
            , IRepositorio<Perfil> perfilRepositorio
            , IRepositorio<Usuario> usuarioRepositorio
            , ICifradoServicio cifradoAplicacionServicio)
        {
            _ciudadRepositorio = ciudadRepositorio;
            _categoriaRepositorio = categoriaRepositorio;
            _empresaRepositorio = empresaRepositorio;
            _empresaCategoriaRepositorio = empresaCategoriaRepositorio;
            _estadoRepositorio = estadoRepositorio;
            _perfilRepositorio = perfilRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
            _cigradoAplicacionServicio = cifradoAplicacionServicio;
        }
        public List<CategoriaDto> ObtenerCategorias()
        {
            return AutoMapper.Mapper.Map<List<CategoriaDto>>(_categoriaRepositorio.ObtenerTodos());
        }

        public List<CiudadDto> ObtenerCiudades()
        {
            return AutoMapper.Mapper.Map<List<CiudadDto>>(_ciudadRepositorio.ObtenerTodos());
        }

        public List<EstadoDto> ObtenerEstados()
        {
            return AutoMapper.Mapper.Map<List<EstadoDto>>(_estadoRepositorio.ObtenerTodos());
        }

        public List<PerfilDto> ObtenerPerfiles()
        {
            return AutoMapper.Mapper.Map<List<PerfilDto>>(_perfilRepositorio.ObtenerTodos());
        }

        public List<SucesoDto> ObtenerSucesos()
        {
            throw new NotImplementedException();
        }

        public List<SucesoDto> ObtenerTopDeSucesos(int top)
        {
            throw new NotImplementedException();
        }

        public List<SucesoDto> ObtenerTopDeSucesosMenorDeId(int top, int SucesoId)
        {
            throw new NotImplementedException();
        }

        public List<EmpresaDto> ObtenerEmpresas()
        {
            return AutoMapper.Mapper.Map<List<EmpresaDto>>(_empresaRepositorio.ObtenerTodos());
        }

        public List<EmpresaCategoriaDto> ObtenerEmpresasPorCategoria()
        {
            return AutoMapper.Mapper.Map<List<EmpresaCategoriaDto>>(_empresaCategoriaRepositorio.ObtenerTodos());
        }


        public List<UsuarioDto> ObtenerUsuarios()
        {
            return AutoMapper.Mapper.Map<List<UsuarioDto>>(_usuarioRepositorio.ObtenerTodos());
        }

        public UsuarioDto AgregarUsuario(UsuarioDto nuevoUsuario)
        {
            var usuario = nuevoUsuario.MapTo<Usuario>();
            var usuarios = _usuarioRepositorio.ObtenerTodos();
            usuario.Clave = _cigradoAplicacionServicio.Cifrar(nuevoUsuario.ClaveNormal);

            string mensaje = "";
            if (! usuario.EsValido(ref mensaje))
            {
                nuevoUsuario.Respuesta = mensaje;
                nuevoUsuario.RespuestaTipo = RespuestaTipo.Validacion;
                return nuevoUsuario;
            }

            bool esCorreoYaRegistrado = usuarios.Any(u => u.Correo == usuario.Correo.Trim());
            if (esCorreoYaRegistrado)
            {
                nuevoUsuario.Respuesta = "El correo ya se encuentra registrado";
                nuevoUsuario.RespuestaTipo = RespuestaTipo.Validacion;
                return nuevoUsuario;
            }

            bool elNombreDeUsuarioYaExiste = usuarios.Any(u => u.Nombre.Trim() == usuario.Nombre.Trim());

            if (elNombreDeUsuarioYaExiste)
            {
                nuevoUsuario.Respuesta = "El nombre del Usuario ya se encuentra Registrado";
                nuevoUsuario.RespuestaTipo = RespuestaTipo.Validacion;
                return nuevoUsuario;
            }

            _usuarioRepositorio.Agregar(usuario);
            _usuarioRepositorio.UnitOfWork.Commit();

            nuevoUsuario.RespuestaTipo = RespuestaTipo.Ok;
            nuevoUsuario.Respuesta = "Usuario creado Exitosamente";
            return nuevoUsuario;

        }

        public UsuarioDto EditarUsuario(UsuarioDto usuarioEdit)
        {
            var usuario = _usuarioRepositorio.FirstOrDefault(u => u.Id == usuarioEdit.ID);

            if (usuario == null)
            {
                usuarioEdit.Respuesta = "El código de Usuario no existe";
                usuarioEdit.RespuestaTipo = RespuestaTipo.Validacion;
                return usuarioEdit;
            }

            usuarioEdit.Respuesta = "Usuario actualizado exitosamente";
            usuarioEdit.RespuestaTipo = RespuestaTipo.Ok;
            return usuarioEdit;
        }

    }
}