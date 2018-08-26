using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Certificaciones
{
   public class CertificacionSolicitanteAgregarDto : BaseDto<CertificacionSolicitanteAgregarDto>
    {
        public int SolicitanteId { get; set; }
        public int CertificacionId { get; set; }
        public String RolDesempena { get; set; }
        public String Comentarios { get; set; }

    }
}
