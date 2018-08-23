using Hackaton.Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class SucesoValoracionDto : BaseDto<SucesoValoracionDto>
    {
        public int SucesoId { get; set; }
        public int UsuarioId { get; set; }
        public int SuesoValoracionTipoId { get; set; }
        public virtual SucesoDto Suceso { get; set; }
        public virtual UsuarioDto Usuario { get; set; }
        public virtual SucesoValoracionTipoDto SuesoValoracionTipo { get; set; }
    }
}