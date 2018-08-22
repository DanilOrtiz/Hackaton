using Hackaton.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class SucesoValoracion : Entidad
    {
        public int SucesoId { get; set; }
        public int UsuarioId { get; set; }
        public int SucesoValoracionId { get; set; }
        public virtual Suceso Suceso { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual SucesoValoracionTipo SuesoValoracionTipo { get; set; }
    }
}