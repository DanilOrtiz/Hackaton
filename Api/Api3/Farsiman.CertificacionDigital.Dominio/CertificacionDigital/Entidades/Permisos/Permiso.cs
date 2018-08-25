using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Permisos
{
    public class Permiso : Entidad
    {
        public Permiso()
        {
        }
        public Permiso(int usuarioAgregaId)
            : base(usuarioAgregaId)
        {
        }

        public string Descripcion { get; set; }
        //public virtual Pantalla Pantalla { get; set; }
        public int PantallaId { get; set; }
        //public virtual ICollection<PerfilPermiso> Perfiles { get; set; }

    }
}
