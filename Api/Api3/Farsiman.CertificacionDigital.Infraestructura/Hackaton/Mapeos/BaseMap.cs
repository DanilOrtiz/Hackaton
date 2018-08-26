using Hackaton.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Property(x => x.FechaAgrega).HasColumnName("Fecha_Crea").IsRequired();
            Property(x => x.UsuarioAgregaId).HasColumnName("Usuario_Agrega_ID").IsRequired();
        }
    }
}
