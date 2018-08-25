using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.UENS
{
    public class UENSDto : BaseDto<UENSDto>
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaAgrega { get; set; }
        public int UsuarioAgregaId { get; set; }
        public bool Activo { get; set; }

    }
}
