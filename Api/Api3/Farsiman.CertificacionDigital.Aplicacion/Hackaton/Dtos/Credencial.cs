using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos
{
   public class Credencial : BaseDto<Credencial>
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
    }
}
