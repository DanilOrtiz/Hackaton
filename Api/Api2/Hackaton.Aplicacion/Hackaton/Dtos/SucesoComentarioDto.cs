using Hackaton.Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class SucesoComentarioDto : BaseDto<SucesoCategoriaDto>
    {
        public int SucesoId { get; set; }
        public string Comentario { get; set; }
        public int UsuarioId { get; set; }
        public virtual SucesoDto Suceso { get; set; }
        public virtual UsuarioDto Usuario { get; set; }
    }
}