using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructura.Hackaton.Mapeos
{
    class UsuarioMap : BaseMap<Usuario>
    {
        public UsuarioMap() : base("Usuario","ID")
        {
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Apellido).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.UsuarioNombre).HasColumnName("Usuario").HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Correo).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Clave).HasColumnType("varbinary").HasMaxLength(500);
            Property(x => x.CiudadId).HasColumnName("Ciudad_Id");
            Property(x => x.PerfilId).HasColumnName("Perfil_Id");
            
            Property(x => x.ImagenUrl).HasColumnName("Imagen").HasColumnType("varchar").HasMaxLength(500);

            //HasRequired(x => x.Ciudad).WithMany(x => x.Usuarios).HasForeignKey(x => x.CiudadId);
            HasRequired(x => x.Perfil).WithMany(x => x.Usuarios).HasForeignKey(x => x.PerfilId);

        }
    }
}