using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;


namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos
{
   public class ProyectoCriterio : Entidad
    {

        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }
        public int Correlativo { get; set; }
        public string Criterio { get; set; }
        public string Certificado { get; set; }
        public DateTime FechaModifica { get; set; }
        public int UsuarioModifica { get; set; }
        public List<CertificacionCriterio> CertificacionCriterio { get; set; }



        public bool EsValido(ref string mensaje)
        {

            if (string.IsNullOrWhiteSpace(Criterio))
            {
                mensaje = "El criterio de aceptación es requerida;";
                return false;
            }

            return true;
        }
    }
}
