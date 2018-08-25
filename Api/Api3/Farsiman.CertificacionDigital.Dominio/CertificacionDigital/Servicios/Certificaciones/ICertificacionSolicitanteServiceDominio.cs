using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Certificaciones
{
    public interface ICertificacionSolicitanteServiceDominio
    {

        bool SonDatosValidos(CertificacionSolicitante certificacionSolicitante, out string mensaje);

    }
}
