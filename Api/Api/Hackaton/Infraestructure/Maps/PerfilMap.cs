using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class PerfilMap : EntidadMap<Perfil>
    {
        public PerfilMap(string tablaNombre) : base(tablaNombre)
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        }
    }
}