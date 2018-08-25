using Hackaton.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class SucesoCategoriaDto : BaseDto<SucesoCategoriaDto>
    {

        public int SucesoId { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaDto Categoria { get; set; }
        public SucesoDto Suceso { get; set; }
    }
}