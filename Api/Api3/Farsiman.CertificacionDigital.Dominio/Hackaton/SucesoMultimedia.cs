using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class SucesoMultimedia : Entidad
    {
        public string Ruta { get; set; }
        public string Nombre { get; set; }
        public int SucesoMultimediaTipoId { get; set; }
        public int SucesoId { get; set; }
        public virtual Suceso Suceso { get; set; }
        public virtual SucesoMultimediaTipo SucesoMultimediaTipo { get; set; }



    }
}