using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Certificaciones
{
    public class CertificacionAgregarDto : BaseDto<CertificacionAgregarDto>
    {
        public int ProyectoId { get; set; }
        public DateTime FechaCertificacion { get; set; }
        public string Estado { get; set; }
    }
}
