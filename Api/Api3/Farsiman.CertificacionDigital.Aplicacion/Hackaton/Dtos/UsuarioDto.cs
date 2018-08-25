using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Application.Dtos
{
    public class UsuarioDto : BaseDto<UsuarioDto>
    {
        public int ID { get; set; }
        public DateTime FechaCrea { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string UsuarioNombre { get; set; }
        public string ClaveNormal { get; set; }
        public string Correo { get; set; }
        public int CiudadId { get; set; }
        public int PerfilId { get; set; }
        public string ImagenUrl { get; set; }
        public virtual List<SucesoDto> Sucesos { get; set; }
    }
}