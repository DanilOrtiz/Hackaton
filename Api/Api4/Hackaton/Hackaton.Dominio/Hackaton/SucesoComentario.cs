using Hackaton.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class SucesoComentario : Entidad
    {
        public int SucesoId { get; set; }
        public string Comentario { get; set; }
        public int UsuarioId { get; set; }
        public virtual Suceso Suceso { get; set; }
        //public virtual Usuario Usuario { get; set; }
    }
}