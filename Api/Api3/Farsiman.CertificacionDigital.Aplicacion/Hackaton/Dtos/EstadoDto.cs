using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class EstadoDto : BaseDto<EstadoDto>
    {
        public string Descripcion { get; set; }
    }
}