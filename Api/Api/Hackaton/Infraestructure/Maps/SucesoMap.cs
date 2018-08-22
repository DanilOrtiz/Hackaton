using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class SucesoMap : EntidadMap<Suceso>
    {
        public SucesoMap(string tablaNombre) : base(tablaNombre)
        {
            Property(x => x.CiudadId).IsOptional();
            Property(x => x.Descripcion).HasColumnType("varchar").HasMaxLength(1000);
            Property(x => x.UsuarioId).IsOptional();
            Property(x => x.Latitud).HasColumnType("numeric(18,6)").IsOptional();
            Property(x => x.CiudadId).IsOptional();
            Property(x => x.EstadoId);
            Property(x => x.EsAnonimo).HasColumnType("bit");

            HasRequired(x => x.Ciudad).WithMany(x => x.Sucesos).HasForeignKey(x => x.CiudadId);
            HasRequired(x => x.Estado).WithMany(x => x.Sucesos).HasForeignKey(x => x.EstadoId);
            HasRequired(x => x.Usuario).WithMany(x => x.Sucesos).HasForeignKey(x => x.UsuarioId);



        }
    }
}