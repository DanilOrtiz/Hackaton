using AutoMapper;
using Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos;
using Hackaton.Application.Dtos;
using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Aplicacion.Hackaton.Mapeos
{
    public class MapeosDto : Profile
    {
        public MapeosDto()
        {

            CreateMap<Categoria, CategoriaDto>();
            CreateMap<CategoriaDto, Categoria>();

            CreateMap<Ciudad, CiudadDto>();
            CreateMap<CiudadDto, Ciudad>();

            CreateMap<Estado, EstadoDto>();
            CreateMap<EstadoDto, Estado>();

            CreateMap<Perfil, PerfilDto>();
            CreateMap<PerfilDto, Perfil>();

            CreateMap<Suceso, SucesoDto>();
            CreateMap<SucesoDto, Suceso>();

            CreateMap<SucesoCategoria, SucesoCategoriaDto>();
            CreateMap<SucesoCategoriaDto, SucesoCategoria>();

            CreateMap<SucesoComentario, SucesoComentarioDto>();
            CreateMap<SucesoComentarioDto, SucesoComentario>();

            CreateMap<SucesoMultimedia, SucesoMultimediaDto>();
            CreateMap<SucesoMultimediaDto, SucesoMultimedia>();

            CreateMap<SucesoMultimediaTipo, SucesoMultimediaTipoDto>();
            CreateMap<SucesoMultimediaTipoDto, SucesoMultimediaTipo>();

            CreateMap<SucesoValoracion, SucesoValoracionDto>();
            CreateMap<SucesoValoracionDto, SucesoValoracion>();

            CreateMap<SucesoValoracionTipo, SucesoValoracionTipoDto>();
            CreateMap<SucesoValoracionTipoDto, SucesoValoracionTipo>();

            CreateMap<Empresa, EmpresaDto>();
            CreateMap<EmpresaDto, Empresa>();

            CreateMap<EmpresaCategoria, EmpresaCategoriaDto>();
            CreateMap<EmpresaCategoriaDto, EmpresaCategoria>();
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<UsuarioDto, Usuario>();


        }
    }
}
