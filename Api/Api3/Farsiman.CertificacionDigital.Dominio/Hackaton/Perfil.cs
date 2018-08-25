using Hackaton.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class Perfil : Entidad
    {
        public string Nombre { get; set; }
        public virtual List<Usuario> Usuarios { get; set; }

    }
}