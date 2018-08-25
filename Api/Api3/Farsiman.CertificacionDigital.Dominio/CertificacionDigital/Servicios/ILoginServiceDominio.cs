using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios
{
    public interface ILoginServiceDominio
    {
        bool SonCredencialesValidas(Usuario usuario, byte[] clave, out string mensajeError);
    }
}
