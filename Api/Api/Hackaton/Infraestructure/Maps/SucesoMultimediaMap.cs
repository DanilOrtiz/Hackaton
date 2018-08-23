using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class SucesoMultimediaMap : EntidadMap<SucesoMultimedia>
    {
        public SucesoMultimediaMap() : base("Suceso_Multimedia")
        {
            Property(x => x.Ruta).HasColumnType("varchar").HasMaxLength(1000);
            Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.SucesoMultimediaTipoId).HasColumnName("Suceso_Multimedia_Tipo_ID");
            Property(x => x.SucesoId).HasColumnName("Suceso_Id");

            HasRequired(x => x.SucesoMultimediaTipo).WithMany(x => x.SucesosMultimedia).HasForeignKey(x => x.SucesoMultimediaTipoId);
            HasRequired(x => x.Suceso).WithMany(x => x.SucesosMultimedia).HasForeignKey(x => x.SucesoId);



        }
    }
}