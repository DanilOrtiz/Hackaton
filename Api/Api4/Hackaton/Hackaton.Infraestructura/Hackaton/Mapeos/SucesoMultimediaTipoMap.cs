using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructura.Hackaton.Mapeos
{
    class SucesoMultimediaTipoMap : BaseMap<SucesoMultimediaTipo>
    {
        public SucesoMultimediaTipoMap() : base("Suceso_Multimedia_Tipo", "ID")
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}