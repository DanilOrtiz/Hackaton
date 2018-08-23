using Hackaton.Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class UsuarioDto : BaseDto<UsuarioDto>
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int CiudadId { get; set; }
        public int PerfilId { get; set; }
        public string ImagenUrl { get; set; }
        public virtual List<SucesoDto> Sucesos { get; set; }
    }
}