using Hackaton.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class Categoria : Entidad
    {
        public string Nombre { get; set; }

        public virtual List<SucesoCategoria> SucesoCategorias { get; set; }
        public virtual List<EmpresaCategoria> EmmpresaCategorias{ get; set; }

    }
}