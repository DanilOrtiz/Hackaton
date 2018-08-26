using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Certificaciones
{
    public class CertificacionCriterioAgregarDTO: BaseDto<CertificacionCriterioAgregarDTO>
    {

 
        public int ProyectoCriterioId { get; set; }
        public string Comentario { get; set; }
        public string Certificado { get; set; }
        public int CertificacionId { get; set; }

    }
}
