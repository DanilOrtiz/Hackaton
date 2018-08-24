using Hackaton.Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class SucesoValoracionTipoDto : BaseDto<SucesoValoracionTipoDto>
    {
        public string Nombre { get; set; }
        public int Valoracion { get; set; }
    }
}