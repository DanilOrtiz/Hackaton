using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones
{
    public class CertificacionCriterio : Entidad
    {

        public int ProyectoCriterioId { get; set; }
        public ProyectoCriterio ProyectoCriterio { get; set; }
        public string Comentario { get; set; }
        public string Certificado { get; set; }
        public int CertificacionId { get; set; }
        public Certificacion Certificacion { get; set; }

        public bool EsValido(ref string mensaje)
        {

           return true;
        }

    }
}
