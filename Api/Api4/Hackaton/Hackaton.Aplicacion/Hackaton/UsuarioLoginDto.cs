using Hackaton.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Aplicacion.Hackaton.Dtos.Usuarios
{
    public class UsuarioLoginDto: BaseDto<UsuarioLoginDto>
    {
        public int UsuarioId { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }

    }
}
