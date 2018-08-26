using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Proyecto
{
    public class ProyectoAgregarDto : BaseDto<ProyectoAgregarDto>
    {

        public string Descripcion { get; set; }
        public string CodigoJira { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int SprintId { get; set; }
        public string Tipo { get; set; }
         public decimal DiasEstimado { get; set; }
        public string Comentario { get; set; }
        public int DepartamentoId { get; set; }
        public int SolicitanteId { get; set; }
    }
}
