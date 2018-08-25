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
        public DateTime FechaAgrega { get; set; }
        public int UsuarioAgregaId { get; set; }
        public bool Activo { get; set; }

        public Entidad()
        {
            Activo = true;
            FechaAgrega = DateTime.Now.Date;
        }


        public Entidad(int usuarioAgregaId)
        {
            Activo = true;
            FechaAgrega = DateTime.Now.Date;
            UsuarioAgregaId = usuarioAgregaId;
        }

    }
}
