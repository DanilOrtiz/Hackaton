﻿using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class EstadoMap : EntidadMap<Estado>
    {
        public EstadoMap() : base("Estado")
        {
            Property(x => x.Descripcion).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        }
    }
}