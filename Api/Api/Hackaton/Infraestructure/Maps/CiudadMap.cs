using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class CiudadMap : EntidadMap<Ciudad>
    {
        public CiudadMap() : base("Ciudad")
        {
            Property(x => x.Latitud).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Longitud).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        }
    }
}