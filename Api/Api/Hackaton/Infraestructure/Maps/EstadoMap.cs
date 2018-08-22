using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class EstadoMap : EntidadMap<Estado>
    {
        public EstadoMap(string tablaNombre) : base(tablaNombre)
        {
            Property(x => x.Descripcion).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        }
    }
}