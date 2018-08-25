using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hackaton.Application.Dtos;
using Hackaton.Domain.Entities;
using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos;

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

        public HackatonService(IRepositorio<Ciudad> ciudadRepositorio
            ,IRepositorio<Categoria> categoriaRepositorio
            , IRepositorio<Empresa> empresaRepositorio
            , IRepositorio<EmpresaCategoria> empresaCategoriaRepositorio
            , IRepositorio<Estado> estadoRepositorio
            , IRepositorio<Perfil> perfilRepositorio)
        {
            _ciudadRepositorio = ciudadRepositorio;
            _categoriaRepositorio = categoriaRepositorio;
            _empresaRepositorio = empresaRepositorio;
            _empresaCategoriaRepositorio = empresaCategoriaRepositorio;
            _estadoRepositorio = estadoRepositorio;
            _perfilRepositorio = perfilRepositorio;

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
    }
}