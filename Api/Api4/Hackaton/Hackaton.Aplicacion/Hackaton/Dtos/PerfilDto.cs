using Hackaton.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class PerfilDto : BaseDto<PerfilDto>
    {
        public string Nombre { get; set; }
    }
}