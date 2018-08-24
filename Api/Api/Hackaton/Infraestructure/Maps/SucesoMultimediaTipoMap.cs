using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class SucesoMultimediaTipoMap : EntidadMap<SucesoMultimediaTipo>
    {
        public SucesoMultimediaTipoMap() : base("Suceso_Multimedia_Tipo")
        {
            Property(x => x.Nombre).HasColumnName("varchar").HasMaxLength(500);
        }
    }
}