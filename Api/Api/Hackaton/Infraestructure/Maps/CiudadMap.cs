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
        public CiudadMap(string tablaNombre) : base(tablaNombre)
        {
            Property(x => x.Latitud).HasColumnType("numeric(18,6)").IsRequired();
            Property(x => x.Longitud).HasColumnType("numeric(18,6)").IsRequired();
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        }
    }
}