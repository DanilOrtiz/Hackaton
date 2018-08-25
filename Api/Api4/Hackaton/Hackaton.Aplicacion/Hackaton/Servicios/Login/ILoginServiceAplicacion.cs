using Hackaton.Aplicacion.Hackaton.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Aplicacion.Hackaton.Servicios.Login
{
   public interface ILoginServiceAplicacion
    {
       void SonCredencialesValidas(UsuarioLoginDto credenciales);
    }
}
