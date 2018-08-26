using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;


namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Certificaciones
{
   public class CertificacionDto : BaseDto<CertificacionDto>
    {
        public int ProyectoId { get; set; }
        public DateTime FechaCertificacion { get; set; }
        public string Estado { get; set; }


    }
}
