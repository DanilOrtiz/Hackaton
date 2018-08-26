using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Solicitantes
{
   public class SolicitanteEditDto: BaseDto<SolicitanteEditDto>
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int DepartamentoId { get; set; }
        public int UsuarioId { get; set; }
        public bool Activo { get; set; }
    }
}
