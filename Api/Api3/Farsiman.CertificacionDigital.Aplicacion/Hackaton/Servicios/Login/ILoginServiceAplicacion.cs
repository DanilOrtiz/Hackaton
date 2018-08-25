using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Login
{
   public interface ILoginServiceAplicacion
    {
       void SonCredencialesValidas(UsuarioLoginDto credenciales);
    }
}
