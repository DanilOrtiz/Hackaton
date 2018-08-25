using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class Suceso : Entidad
    {
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int SucesoCaracteristicaId { get; set; }
        public bool EsAnonimo { get; set; }
        public int CiudadId { get; set; }
        public int EstadoId { get; set; }
        //public virtual Usuario Usuario { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public virtual List<SucesoCategoria> SucesoCategorias { get; set; }
        public virtual List<SucesoComentario> SucesoComentarios { get; set; }
        public virtual List<SucesoMultimedia> SucesosMultimedia { get; set; }
        public virtual List<SucesoValoracion> SucesosValoracion { get; set; }
        public virtual Estado Estado { get; set; }
        public bool EsValido(out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                mensaje = "La descripción es requerida";
                return false;
            }
            
            mensaje = "Ok";
            return true;
        }
    }
}