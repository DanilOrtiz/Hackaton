using Hackaton.Domain.Entities;
using Hackaton.Infraestructura.Hackaton.Mapeos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    class CategoriaMap : BaseMap<Categoria>
    {
        public CategoriaMap() : base("Categoria", "ID")
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        }
    }
}