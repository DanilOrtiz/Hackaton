using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.UENS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital
{
   public interface IUENSAplicacionService
    {
       void AgregarUEN(UENSAgregarDto uenNuevo);
        void EditarUEN(UENEditDto uenEdit);
       List<UENSDto> ObtenerUENSActivos();
    }
}
