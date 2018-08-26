using Farsiman.CertificacionDigital.Aplicacion.Core;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.UENS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Departamentos
{
   public class DepartamentoEditDto: BaseDto<DepartamentoEditDto>
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int UENId { get; set; }
        public UEN UEN { get; set; }
        public bool Activo { get; set; }
    }
}
