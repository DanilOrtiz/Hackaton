using Hackaton.Domain.Entities;
using Hackaton.Infraestructura.Hackaton.Mapeos;
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