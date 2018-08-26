using Hackaton.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class CategoriaDto : BaseDto<CategoriaDto>
    {
        public string Nombre { get; set; }
        public DateTime FechaAgrega { get; set; }
    }
}