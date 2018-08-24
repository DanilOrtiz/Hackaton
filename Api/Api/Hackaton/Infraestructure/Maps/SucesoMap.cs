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
        public SucesoMap() : base("Suceso")
        {
            Property(x => x.CiudadId).HasColumnName("Ciudad_Id").IsOptional();
            Property(x => x.Descripcion).HasColumnType("varchar").HasMaxLength(1000);
            Property(x => x.UsuarioId).HasColumnName("Usuario_Id").IsOptional();
            Property(x => x.Latitud).HasColumnType("varchar").HasMaxLength(500).IsOptional();
            Property(x => x.Longitud).HasColumnType("varchar").HasMaxLength(500).IsOptional();
            Property(x => x.EstadoId).HasColumnName("Estado_Id");
            Property(x => x.EsAnonimo).HasColumnType("bit");

            HasRequired(x => x.Ciudad).WithMany(x => x.Sucesos).HasForeignKey(x => x.CiudadId);
            HasRequired(x => x.Estado).WithMany(x => x.Sucesos).HasForeignKey(x => x.EstadoId);
            HasRequired(x => x.Usuario).WithMany(x => x.Sucesos).HasForeignKey(x => x.UsuarioId);



        }
    }
}