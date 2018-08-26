using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.UENS
{
    public class UENSAgregarDto : BaseDto<UENSAgregarDto>
    {
        public string Descripcion { get; set; }
    }
}
