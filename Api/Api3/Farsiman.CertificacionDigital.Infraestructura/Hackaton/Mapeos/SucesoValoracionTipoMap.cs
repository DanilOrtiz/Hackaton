using Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital.Mapeos;
using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    class SucesoValoracionTipoMap : BaseMap<SucesoValoracionTipo>
    {
        public SucesoValoracionTipoMap() : base("Suceso_Valoracion_Tipo","ID")
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Valoracion);

        }
    }
}