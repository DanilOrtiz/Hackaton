using AutoMapper;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Certificaciones;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Departamentos;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Proyecto;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Solicitantes;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Sprints;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.UENS;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios;
using Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Sprints;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.UENS;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using Hackaton.Application.Dtos;
using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades = Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades;
namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Mapeos
{
    public class MapeosDto : Profile
    {
        public MapeosDto()
        {
            //CreateMap<Usuario, UsuarioDto>();
            //CreateMap<UsuarioDto, Usuario>();

            CreateMap<UEN,UENSDto>();
            CreateMap<UENSDto,UEN>();

            CreateMap<UEN, UENSAgregarDto>();
            CreateMap<UENSAgregarDto, UEN>();

            CreateMap<Sprint, SprintDto>();
            CreateMap<SprintDto, Sprint>();

            CreateMap<Sprint, SprintAgregarDto>();
            CreateMap<SprintAgregarDto, Sprint>();

            CreateMap<Departamento, DepartamentoDto>();
            CreateMap<DepartamentoDto, Departamento>();

            CreateMap<Departamento, DepartamentoAgregarDto>();
            CreateMap<DepartamentoAgregarDto, Departamento>();

            CreateMap<Solicitante, SolicitanteDto>();
            CreateMap<SolicitanteDto, Solicitante>();

            CreateMap<Solicitante, SolicitanteAgregarDto>();
            CreateMap<SolicitanteAgregarDto, Solicitante>();

            CreateMap<Proyecto, ProyectoDto>();
            CreateMap<ProyectoDto, Proyecto>();


            CreateMap<Proyecto, ProyectoAgregarDto>();
            CreateMap<ProyectoAgregarDto, Proyecto>();

            CreateMap<Certificacion, CertificacionDto>();
            CreateMap<CertificacionDto, Certificacion>();

            CreateMap<Certificacion, CertificacionAgregarDto>();
            CreateMap<CertificacionAgregarDto, Certificacion>();


            CreateMap<ProyectoCriterio, ProyectoCriterioDto>();
            CreateMap<ProyectoCriterioDto, ProyectoCriterio>();

            CreateMap<ProyectoCriterio, ProyectoCriterioAgregarDto>();
            CreateMap<ProyectoCriterioAgregarDto, ProyectoCriterio>();

            CreateMap<CertificacionCriterio, CertificacionCriterioAgregarDTO>();
            CreateMap<CertificacionCriterioAgregarDTO, CertificacionCriterio>();

            CreateMap<CertificacionCriterio, CertificacionCriterioDto>();
            CreateMap<CertificacionCriterioDto, CertificacionCriterio>();

            CreateMap<CertificacionSolicitante, CertificacionSolicitanteAgregarDto>();
            CreateMap<CertificacionSolicitanteAgregarDto, CertificacionSolicitante>();


            CreateMap<CertificacionSolicitante, CertificacionSolicitanteDto>();
            CreateMap<CertificacionSolicitanteDto, CertificacionSolicitante>();

            //CreateMap<UsuarioAgregarDto, Usuario>()
            //    .ForMember(s => s.Clave, o => o.Ignore());

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
            //CreateMap<Usuario, UsuarioDto>();
            //CreateMap<UsuarioDto, Usuario>();


        }
    }
}
