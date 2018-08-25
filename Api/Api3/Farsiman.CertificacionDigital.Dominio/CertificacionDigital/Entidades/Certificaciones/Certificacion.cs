using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Sprints;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones
{
    public class Certificacion : Entidad
    {


        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }
        public DateTime FechaCertificacion { get; set; }
        public string Estado { get; set; }
        public List<CertificacionCriterio> CertificacionCriterio { get; set; }
        public List<CertificacionSolicitante> CertificacionSolicitante { get; set; }

        public bool EsValido(ref string mensaje)
        {

            if (string.IsNullOrWhiteSpace(Estado))
            {

                mensaje = "El estado es requerido;";
                return false;
            }

            if (FechaCertificacion.Date < DateTime.Now)
            {

                mensaje = "La fecha de Certificación es menor que la fecha actual;";
                return false;
            }

            return true;
        }

    }
}
