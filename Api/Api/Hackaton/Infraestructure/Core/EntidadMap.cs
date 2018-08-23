using Hackaton.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Core
{
    public class EntidadMap<TEntidad> : EntityTypeConfiguration<TEntidad> where TEntidad : Entidad
    {
        public EntidadMap(string tablaNombre)
        {
            HasKey(x => x.Id);
            //                                      CAMPO                   TIPO               
            Property(x => x.Activo).HasColumnType("bit").IsRequired();
            Property(x => x.FechaCrea).HasColumnName("Fecha_Crea").HasColumnType("datetime").IsRequired();
            Property(x => x.Id).HasColumnType("int").IsRequired();


        }
    }
}