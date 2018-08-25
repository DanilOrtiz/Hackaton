using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class SucesoMultimediaDto : BaseDto<SucesoMultimediaDto>
    {
        public string Ruta { get; set; }
        public string Nombre { get; set; }
        public int SucesoMultimediaTipoId { get; set; }
        public int SucesoId { get; set; }
        public virtual SucesoDto Suceso { get; set; }
        public virtual SucesoMultimediaTipoDto SucesoMultimediaTipo { get; set; }
    }
}