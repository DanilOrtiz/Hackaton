using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;
using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes
{
    public class Solicitante : Entidad
    {

        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int DepartamentoID { get; set; }
        public virtual Departamento Departamento { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public List<Proyecto> Proyecto { get; set; }
        public List<CertificacionSolicitante> CertificacionSolicitante { get; set; }

        public bool EsValido(ref string mensaje)
        {
            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                mensaje = "La descripcion es requerido";
                return false;
            }


            if (string.IsNullOrWhiteSpace(Correo))
            {
                mensaje = "El correo es requerido";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Telefono))
            {
                mensaje = "El Telefono es requerido";
                return false;
            }

            

            return true;
        }
    }
}
