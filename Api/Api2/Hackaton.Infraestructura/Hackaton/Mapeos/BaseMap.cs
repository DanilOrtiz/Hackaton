using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Hackaton.Dominio.Core;

namespace Hackaton.Infraestructura.Hackaton.Mapeos
{
    class BaseMap<TEntidad> : EntityTypeConfiguration<TEntidad> where TEntidad : Entidad
    {
        public BaseMap(string tablaNombre, string columnaIdNombre)
        {
            ToTable(tablaNombre);
            Property(x => x.Id).HasColumnName(columnaIdNombre);
            HasKey(x => x.Id);
            Property(x => x.Activo).HasColumnName("Activo").IsRequired();
            Property(x => x.FechaCrea).HasColumnName("Fecha_Crea").IsRequired();
        }
    }
}
