using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital.Mapeos
{
    class DepartamentosMap : BaseMap<Departamento>
    {

        public DepartamentosMap()
           : base("Departamentos", "ID")
       {
           Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(90).IsRequired();
            Property(x => x.UENId).HasColumnName("UEN_ID").HasColumnType("int").IsRequired();
           HasRequired(x => x.UEN).WithMany(x => x.Departamento).HasForeignKey(x => x.UENId);
          
       }

    }
}
