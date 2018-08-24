using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Dominio.Core
{
    public class Entidad
    {

        public int Id { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Activo { get; set; }

        public Entidad()
        {
            Activo = true;
            FechaCrea = DateTime.Now.Date;
        }


        public Entidad(int usuarioAgregaId)
        {
            Activo = true;
            FechaCrea = DateTime.Now.Date;
        }

    }
}
