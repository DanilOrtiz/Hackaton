using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos
{
    public class EmpresaDto : BaseDto<EmpresaDto>
    {
        public string Nombre { get; set; }
        public string ImagenEmpresa { get; set; }
        public string BannerEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string WhatsappEmpresa { get; set; }
        public string CorreoEmpresa { get; set; }
        public string SitioWeb { get; set; }
        public string DireccionEmpresa { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string NombreContacto { get; set; }
        public string CorreoContacto { get; set; }
        public int UsuarioID { get; set; }
        public bool EsGubernamental { get; set; }
    }
}
