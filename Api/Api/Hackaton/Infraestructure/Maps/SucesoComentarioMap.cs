using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class SucesoComentarioMap : EntidadMap<SucesoComentario>
    {
        public SucesoComentarioMap() : base("Suceso_Comentario")
        {
            Property(x=>x.Comentario).HasColumnType("varchar").HasMaxLength(5000);
            Property(x => x.SucesoId).HasColumnName("Suceso_Id");
            Property(x => x.UsuarioId).HasColumnName("Usuario_Id");

            HasRequired(x => x.Usuario).WithMany(x => x.SucesosComentarios).HasForeignKey(x => x.UsuarioId);
            HasRequired(x => x.Suceso).WithMany(x => x.SucesoComentarios).HasForeignKey(x => x.SucesoId);
        }
    }
}