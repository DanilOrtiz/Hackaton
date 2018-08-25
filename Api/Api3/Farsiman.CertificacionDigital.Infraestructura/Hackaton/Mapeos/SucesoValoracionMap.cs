using Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital.Mapeos;
using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    class SucesoValoracionMap : BaseMap<SucesoValoracion>
    {
        public SucesoValoracionMap() : base("Suceso_Valoracion","ID")
        {
            Property(x => x.SucesoId).HasColumnName("Suceso_Id");
            Property(x => x.UsuarioId).HasColumnName("Usuario_Id");
            Property(x => x.SucesoValoracionId).HasColumnName("Suceso_Valoracion_Tipo_ID");

            HasRequired(x => x.Suceso).WithMany(x => x.SucesosValoracion).HasForeignKey(x => x.SucesoId);
            //HasRequired(x => x.Usuario).WithMany(x => x.SucesosValoraciones).HasForeignKey(x => x.UsuarioId);
            HasRequired(x => x.SuesoValoracionTipo).WithMany(x => x.SucesosValoracion).HasForeignKey(x => x.SucesoValoracionId);


        }
    }
}