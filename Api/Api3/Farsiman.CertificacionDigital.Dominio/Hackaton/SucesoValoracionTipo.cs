using Hackaton.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class SucesoValoracionTipo : Entidad
    {
        public string Nombre { get; set; }
        public int Valoracion { get; set; }

        public virtual List<SucesoValoracion> SucesosValoracion { get; set; }
    }
}