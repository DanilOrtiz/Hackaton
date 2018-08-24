using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class UsuarioMap : EntidadMap<Usuario>
    {
        public UsuarioMap() : base("Usuario")
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Correo).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Clave).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.ClaveEncriptada).HasColumnType("varbinary").HasMaxLength(500);
            Property(x => x.CiudadId).HasColumnName("Ciudad_Id");
            Property(x => x.PerfilId).HasColumnName("Perfil_Id");
            
            Property(x => x.ImagenUrl).HasColumnName("Imagen").HasColumnType("varchar").HasMaxLength(500);

            //HasRequired(x => x.Ciudad).WithMany(x => x.Usuarios).HasForeignKey(x => x.CiudadId);
            HasRequired(x => x.Perfil).WithMany(x => x.Usuarios).HasForeignKey(x => x.PerfilId);

        }
    }
}