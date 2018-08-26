using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructura.Hackaton.Mapeos
{
    class EstadoMap : BaseMap<Estado>
    {
        public EstadoMap() : base("Estado","ID")
        {
            Property(x => x.Descripcion).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        }
    }
}