using Hackaton.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class Ciudad : Entidad
    {
        public string Nombre { get; set; }
        public long Latitud { get; set; }
        public long Longitud { get; set; }
    }
}