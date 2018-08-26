using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class CiudadDto : BaseDto<CiudadDto>
    {
        public string Nombre { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
    }
}