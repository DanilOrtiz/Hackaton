using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios
{
    public class UsuarioAgregarDto : BaseDto<UsuarioAgregarDto>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public int CodigoColaborador { get; set; }
        public string CorreoElectronico { get; set; }
        public int PerfilId { get; set; }
    }
}
