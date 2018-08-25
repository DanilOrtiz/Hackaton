using Farsiman.CertificacionDigital.Aplicacion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Solicitantes
{
    public class SolicitanteDto : BaseDto<SolicitanteDto>
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int DepartamentoId { get; set; }
        public int UsuarioId { get; set; }
        public  Departamento Departamento { get; set; }
        public Usuario Usuario { get; set; }
        public bool Activo { get; set; }

    }
}
