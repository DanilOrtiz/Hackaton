using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Sprints
{
    public class SprintDto : BaseDto<SprintDto>
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaModifica { get; set; } 
        public int? UsuarioModifica { get; set; }
        public DateTime FechaAgrega { get; set; }
        public int UsuarioAgregaId { get; set; }

    }
}
