using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Proyecto
{
   public  class ProyectoCriterioAgregarDto : BaseDto<ProyectoCriterioAgregarDto>
    {
        public int ProyectoId { get; set; }
        public int Correlativo { get; set; }
        public string Criterio { get; set; }
        public string Certificado { get; set; }
    }
}
