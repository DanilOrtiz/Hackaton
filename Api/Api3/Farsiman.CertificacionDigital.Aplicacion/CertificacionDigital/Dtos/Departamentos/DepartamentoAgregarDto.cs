using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Departamentos
{
    public class DepartamentoAgregarDto : BaseDto<DepartamentoAgregarDto>
    {

        public string Descripcion { get; set; }
        public int UENId { get; set; }
    }
}
