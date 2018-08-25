using Farsiman.CertificacionDigital.Dominio.Core;
using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class Ciudad : Entidad
    {
        public string Nombre { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }

        public virtual List<Suceso> Sucesos { get; set; }
        //public virtual List<Usuario> Usuarios{ get; set; }

    }
}