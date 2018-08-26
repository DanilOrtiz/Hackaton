using Hackaton.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos;
using Hackaton.Application.Dtos;
using Hackaton.Domain.Entities;
using Hackaton.Aplicacion.Hackaton.Dtos;
using Hackaton.Dominio.Core.Repositorios;
using Hackaton.Aplicacion.Core;

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
            var resultado = AutoMapper.Mapper.Map<List<SucesoDto>>(_sucesoRepositorio.ObtenerTodos());
            resultado.ForEach(data =>
            {
                data.FechaAgrega = data.FechaAgrega.Date;
            });
            return resultado;
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

        public SucesoDto CrearSuceso(SucesoDto suceso)
        {
            try
            {
                RespuestaTipo respuestaValidaciones = RespuestaTipo.Ok;
                String mensajeError = string.Empty;
                suceso = ValidarPropiedadesDeSuceso(suceso);
                if (suceso.RespuestaTipo != RespuestaTipo.Ok)
                {
                    return suceso;
                }
                suceso.EstadoId = EnumEstados.Nuevo;

                Suceso sucesoEntidad = AutoMapper.Mapper.Map<Suceso>(suceso);
                _sucesoRepositorio.Agregar(sucesoEntidad);
                _sucesoRepositorio.UnitOfWork.SaveChanges();
                suceso.RespuestaTipo = RespuestaTipo.Ok;
                return suceso;
            }
            catch (Exception ex)
            {
                return new SucesoDto()
                {
                    Respuesta = "Lo sentimos se presentó un incoveniente al crear su noticia!",
                    RespuestaTipo = RespuestaTipo.Excepcion
                };
            }
        }

        private SucesoDto ValidarPropiedadesDeSuceso(SucesoDto suceso)
        {
            suceso.RespuestaTipo = RespuestaTipo.Ok;

            if (suceso == null)
            {
                suceso = new SucesoDto()
                {
                    Respuesta = "No se encontró información!",
                    RespuestaTipo = RespuestaTipo.Validacion
                };
                return suceso;
            }
            if (suceso.SucesosMultimedia == null)
            {
                return new SucesoDto()
                {
                    Respuesta = "Favor ingrese un archivo multimedia para detallar mas su noticia!",
                    RespuestaTipo = RespuestaTipo.Validacion
                };
            }
            if (suceso.SucesoCategorias == null)
            {
                return new SucesoDto()
                {
                    Respuesta = "Favor detalle la categoría de su noticia!",
                    RespuestaTipo = RespuestaTipo.Validacion
                };
            }
            suceso.SucesosMultimedia.ForEach(data =>
            {
                if (String.IsNullOrEmpty(data.Ruta))
                {
                    suceso.Respuesta = "La ruta del archivo es inválida!";
                    suceso.RespuestaTipo = RespuestaTipo.Validacion;
                }
                if (string.IsNullOrEmpty(data.Nombre))
                {
                    suceso.Respuesta = "Nombre del archivo inválido!";
                    suceso.RespuestaTipo = RespuestaTipo.Validacion;
                }
            });
            suceso.SucesoCategorias.ForEach(data =>
            {
                if (data.CategoriaId == 0)
                {
                    suceso.Respuesta = "Categoría inválida!";
                    suceso.RespuestaTipo = RespuestaTipo.Validacion;
                }
            });
            if (suceso.CiudadId == 0)
            {
                suceso.Respuesta = "Ciudad inválida!";
                suceso.RespuestaTipo = RespuestaTipo.Validacion;
            }
            if (String.IsNullOrEmpty(suceso.Descripcion))
            {
                suceso.Respuesta = "Se necesita una descripción del suceso!";
                suceso.RespuestaTipo = RespuestaTipo.Validacion;
            }

            if (string.IsNullOrEmpty(suceso.Latitud))
            {
                suceso.Respuesta = "Latitud no reconocida!";
                suceso.RespuestaTipo = RespuestaTipo.Validacion;
            }

            if (string.IsNullOrEmpty(suceso.Longitud))
            {
                suceso.Respuesta = "Longitud no reconocida!";
                suceso.RespuestaTipo = RespuestaTipo.Validacion;
            }
            if (suceso.EsAnonimo == false && suceso.UsuarioId == 0)
            {
                suceso.Respuesta = "Ocurrio un problema con el usuario logueado intente de nuevo o mas tarde!";
                suceso.RespuestaTipo = RespuestaTipo.Validacion;
            }

            return suceso;
        }

        public SucesoDto AnularSuceso(SucesoDto suceso)
        {
            try
            {
                if (suceso == null)
                {
                    return new SucesoDto() { Respuesta = "No se encontró información!", RespuestaTipo = RespuestaTipo.Validacion };
                }

                if (suceso.Id == 0)
                {
                    return new SucesoDto() { Respuesta = "No se encontró la noticia para poder anular!", RespuestaTipo = RespuestaTipo.Validacion };
                }

                Suceso sucesoPorId = _sucesoRepositorio.ObtenerPorID(suceso.Id);

                if (sucesoPorId == null)
                {
                    return new SucesoDto() { Respuesta = "No se encontró información!", RespuestaTipo = RespuestaTipo.Validacion };
                }

                sucesoPorId.EstadoId = (int)EnumEstados.AnuladoPorUsuario;
                _sucesoRepositorio.UnitOfWork.SaveChanges();

                return AutoMapper.Mapper.Map<SucesoDto>(sucesoPorId);
            }
            catch (Exception ex)
            {
                return new SucesoDto() { Respuesta = "No se encontró información!", RespuestaTipo = RespuestaTipo.Validacion };
            }

        }


        public SucesoDto ValorarSuceso(int sucesoId, int valoracion, int usuarioId)
        {
            try
            {
                if (sucesoId == 0 || valoracion == 0)
                {
                    return new SucesoDto() { Respuesta = "No se encontró información!", RespuestaTipo = RespuestaTipo.Validacion };
                }

                Suceso resultadoInfo = _sucesoRepositorio.FirstOrDefault(x => x.Id == sucesoId);

                if (resultadoInfo == null)
                {
                    return new SucesoDto() { Respuesta = "No se encontró información!", RespuestaTipo = RespuestaTipo.Validacion };
                }

                var valorar = new SucesoValoracion()
                {
                    SucesoId = sucesoId,
                    SucesoValoracionId = valoracion,
                    UsuarioId = usuarioId,
                    UsuarioAgregaId = 0
                };

                _sucesoValoracionRepositorio.Agregar(valorar);
                _sucesoValoracionRepositorio.UnitOfWork.SaveChanges();
                _sucesoValoracionRepositorio.UnitOfWork.Commit();

                return new SucesoDto() { Respuesta = "Ok", RespuestaTipo = RespuestaTipo.Ok };
            }
            catch (Exception ex)
            {
                return new SucesoDto() { Respuesta = "No se encontró información!", RespuestaTipo = RespuestaTipo.Validacion };
            }

        }
    }
}
