using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Certificaciones
{
    public interface ICertificacionServiceDominio
    {

        bool SonDatosValidos(Certificacion certificacion, out string mensajeError);
    }
}
