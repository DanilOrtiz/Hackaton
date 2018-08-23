using Hackaton.Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class CiudadDto : BaseDto<CiudadDto>
    {
        public string Nombre { get; set; }
        public long Latitud { get; set; }
        public long Longitud { get; set; }
    }
}