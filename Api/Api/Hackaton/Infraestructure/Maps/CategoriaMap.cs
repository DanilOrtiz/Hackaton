using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class CategoriaMap : EntidadMap<Categoria>
    {
        public CategoriaMap() : base("Categoria")
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        }
    }
}