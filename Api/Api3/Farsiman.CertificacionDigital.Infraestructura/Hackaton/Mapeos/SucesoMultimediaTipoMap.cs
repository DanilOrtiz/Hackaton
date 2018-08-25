using Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital.Mapeos;
using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    class SucesoMultimediaTipoMap : BaseMap<SucesoMultimediaTipo>
    {
        public SucesoMultimediaTipoMap() : base("Suceso_Multimedia_Tipo","ID")
        {
            Property(x => x.Nombre).HasColumnName("varchar").HasMaxLength(500);
        }
    }
}