using Hackaton.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackaton.Application.Dtos;
using Hackaton.Domain.Entities;
using Hackaton.Dominio.Core.Repositorios;

namespace Hackaton.Aplicacion.Hackaton.Servicios
{
    public class HackatonAppService : IHackatonAppService
    {
        private readonly IRepositorio<SucesoCategoria> _sucesoCategoriaRepositorio;
        private readonly IRepositorio<SucesoComentario> _sucesoComentarioRepositorio;
        private readonly IRepositorio<SucesoMultimedia> _sucesoMultimediaRepositorio;
        private readonly IRepositorio<SucesoValoracion> _sucesoValoracionRepositorio;
        private readonly IRepositorio<Suceso> _sucesoRepositorio;


        public HackatonAppService(IRepositorio<SucesoCategoria> sucesoCategoriaRepositorio,
            IRepositorio<SucesoComentario> sucesoComentarioRepositorio,
            IRepositorio<SucesoMultimedia> sucesoMultimediaRepositorio,
            IRepositorio<SucesoValoracion> sucesoValoracionRepositorio,
            IRepositorio<Suceso> sucesoRepositorio)
        {
            _sucesoCategoriaRepositorio = sucesoCategoriaRepositorio;
            _sucesoComentarioRepositorio = sucesoComentarioRepositorio;
            _sucesoMultimediaRepositorio = sucesoMultimediaRepositorio;
            _sucesoValoracionRepositorio = sucesoValoracionRepositorio;
            _sucesoRepositorio = sucesoRepositorio;
        }
        public List<SucesoCategoriaDto> ObtenerSucesoCategorias()
        {
            return AutoMapper.Mapper.Map<List<SucesoCategoriaDto>>(_sucesoCategoriaRepositorio.ObtenerTodos());
        }

        public List<SucesoDto> ObtenerSucesos()
        {
            return AutoMapper.Mapper.Map<List<SucesoDto>>(_sucesoRepositorio.ObtenerTodos());
        }

        public List<SucesoComentarioDto> ObtenerSucesosComentarios()
        {
            return AutoMapper.Mapper.Map<List<SucesoComentarioDto>>(_sucesoComentarioRepositorio.ObtenerTodos());
        }

        public List<SucesoMultimediaDto> ObtenerSucesosMultimedia()
        {
            return AutoMapper.Mapper.Map<List<SucesoMultimediaDto>>(_sucesoMultimediaRepositorio.ObtenerTodos());
        }

        public List<SucesoValoracionDto> ObtenerSucesosValoracion()
        {
            return AutoMapper.Mapper.Map<List<SucesoValoracionDto>>(_sucesoValoracionRepositorio.ObtenerTodos());
        }
    }
}
