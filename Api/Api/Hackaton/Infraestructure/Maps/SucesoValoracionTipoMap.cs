using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class SucesoValoracionTipoMap : EntidadMap<SucesoValoracionTipo>
    {
        public SucesoValoracionTipoMap() : base("Suceso_Valoracion_Tipo")
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Valoracion);

        }
    }
}