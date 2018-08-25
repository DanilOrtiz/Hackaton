using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructura.Hackaton.Mapeos
{
    class SucesoComentarioMap : BaseMap<SucesoComentario>
    {
        public SucesoComentarioMap() : base("Suceso_Comentario", "ID")
        {
            Property(x => x.Comentario).HasColumnType("varchar").HasMaxLength(5000);
            Property(x => x.SucesoId).HasColumnName("Suceso_Id");
            Property(x => x.UsuarioId).HasColumnName("Usuario_Id");

            //HasRequired(x => x.Usuario).WithMany(x => x.SucesosComentarios).HasForeignKey(x => x.UsuarioId);
            HasRequired(x => x.Suceso).WithMany(x => x.SucesoComentarios).HasForeignKey(x => x.SucesoId);
        }
    }
}