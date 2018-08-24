using Hackaton.Domain.Entities;
using Hackaton.Infraestructura.Hackaton.Mapeos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    class CiudadMap : BaseMap<Ciudad>
    {
        public CiudadMap() : base("Ciudad","ID")
        {
            Property(x => x.Latitud).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Longitud).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        }
    }
}