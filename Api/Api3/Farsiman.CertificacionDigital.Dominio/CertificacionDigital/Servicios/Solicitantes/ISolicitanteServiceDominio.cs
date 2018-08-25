using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Solicitantes
{
   public  interface ISolicitanteServiceDominio
    {
       bool SonDatosValidos(Solicitante solicitante, out string mensajeError);
 
    }
}
