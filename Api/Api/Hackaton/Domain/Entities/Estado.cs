using Hackaton.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class Estado : Entidad
    {
        public string Descripcion { get; set; }

        public virtual List<Suceso> Sucesos { get; set; }
    }
}