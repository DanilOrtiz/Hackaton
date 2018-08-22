using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Core
{
    public class Entidad
    {
        public int Id { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Activo { get; set; }
    }
}