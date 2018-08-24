using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class EmpresaMap : EntidadMap<Empresa>
    {
        public EmpresaMap() : base("Empresa")
        {
            Property(x => x.BannerEmpresa).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.ImagenEmpresa).HasColumnType("varchar").HasMaxLength(1500);
            Property(x => x.BannerEmpresa).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.TelefonoEmpresa).HasColumnType("varchar").HasMaxLength(11);
            Property(x => x.WhatsappEmpresa).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.CorreoEmpresa).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.SitioWeb).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.DireccionEmpresa).HasColumnType("varchar").HasMaxLength(1000);
            Property(x => x.Latitud).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Longitud).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.NombreContacto).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.CorreoContacto).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.UsuarioID).HasColumnName("Usuario_ID");
            Property(x => x.EsGubernamental).HasColumnType("bit");

            HasRequired(x => x.Usuario).WithMany(x => x.Empresas).HasForeignKey(x => x.UsuarioID);
        }
    }
}