﻿using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructura.Hackaton.Mapeos
{
    class PerfilMap : BaseMap<Perfil>
    {
        public PerfilMap() : base("Perfil","ID")
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        }
    }
}