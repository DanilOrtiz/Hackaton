using Hackaton.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class SucesoDto : BaseDto<SucesoDto>
    {
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool EsAnonimo { get; set; }
        public int CiudadId { get; set; }
        public int EstadoId { get; set; }
        public virtual UsuarioDto Usuario { get; set; }
        public virtual CiudadDto Ciudad { get; set; }
        public virtual List<SucesoCategoriaDto> SucesoCategorias { get; set; }
        public virtual List<SucesoComentarioDto> SucesoComentarios { get; set; }
        public virtual List<SucesoMultimediaDto> SucesosMultimedia { get; set; }
        public virtual List<SucesoValoracionDto> SucesosValoracion { get; set; }
        public virtual EstadoDto Estado { get; set; }
    }
}