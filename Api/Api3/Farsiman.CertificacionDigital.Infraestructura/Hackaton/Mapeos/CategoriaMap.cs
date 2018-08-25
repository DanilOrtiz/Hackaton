using Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital.Mapeos;
using Hackaton.Domain.Entities;
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