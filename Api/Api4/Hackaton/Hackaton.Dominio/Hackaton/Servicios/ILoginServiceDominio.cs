using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Dominio.Hackaton.Servicios
{
    public interface ILoginServiceDominio
    {
        bool SonCredencialesValidas(Usuario usuario, byte[] clave, out string mensajeError);
    }
}
