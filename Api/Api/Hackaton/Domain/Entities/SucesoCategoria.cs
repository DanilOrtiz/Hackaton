using Hackaton.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class SucesoCategoria : Entidad
    {
        public string Nombre { get; set; }
        public string SucesoId { get; set; }
        public int CategoriaId { get; set; }
        public virtual Suceso Suceso { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}