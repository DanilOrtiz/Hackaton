﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hackaton.Application.Dtos;
using Hackaton.Domain.Entities;
using Hackaton.Dominio.Core.Repositorios;

namespace Hackaton.Application.Services
{
    public class HackatonService : IHackatonService
    {

        private readonly IRepositorio<Ciudad> _ciudadRepositorio;
        private readonly IRepositorio<Categoria> _categoriaRepositorio;

        public HackatonService(IRepositorio<Ciudad> ciudadRepositorio, IRepositorio<Categoria> categoriaRepositorio)
        {
            _ciudadRepositorio = ciudadRepositorio;
            _categoriaRepositorio = categoriaRepositorio;
        }
        public List<CategoriaDto> ObtenerCategorias()
        {
            return AutoMapper.Mapper.Map<List<CategoriaDto>>(_categoriaRepositorio.ObtenerTodos());
        }

        public List<CiudadDto> ObtenerCiudades()
        {
            throw new NotImplementedException();
        }

        public List<EstadoDto> ObtenerEstados()
        {
            throw new NotImplementedException();
        }

        public List<PerfilDto> ObtenerPerfiles()
        {
            throw new NotImplementedException();
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
    }
}