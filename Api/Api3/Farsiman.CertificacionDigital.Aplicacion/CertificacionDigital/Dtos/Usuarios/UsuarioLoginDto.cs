using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios
{
    public class UsuarioLoginDto: BaseDto<UsuarioLoginDto>
    {
        public string Correo { get; set; }
        public string Clave { get; set; }

    }
}
