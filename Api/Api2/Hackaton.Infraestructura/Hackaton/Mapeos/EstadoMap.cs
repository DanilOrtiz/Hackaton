using Hackaton.Domain.Entities;
using Hackaton.Infraestructura.Hackaton.Mapeos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    class EstadoMap : BaseMap<Estado>
    {
        public EstadoMap() : base("Estado","ID")
        {
            Property(x => x.Descripcion).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        }
    }
}