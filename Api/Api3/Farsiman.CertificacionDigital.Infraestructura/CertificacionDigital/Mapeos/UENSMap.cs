using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.UENS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital.Mapeos
{
    class UENSMap : BaseMap<UEN>
    {
       public UENSMap()
           : base("UENS", "ID")
       {
           Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(80).IsRequired();
       }
    }
}
