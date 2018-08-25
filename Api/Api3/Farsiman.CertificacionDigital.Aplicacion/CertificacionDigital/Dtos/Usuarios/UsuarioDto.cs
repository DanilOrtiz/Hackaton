using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios
{
    public class UsuarioDto : BaseDto<UsuarioDto>
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public byte[] Clave { get; set; }
        public int CodigoColaborador { get; set; }
        public string CorreoElectronico { get; set; }
        public int PerfilId { get; set; }
    }
}
