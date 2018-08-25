using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones
{
    public class CertificacionSolicitante : Entidad
    {
        public int SolicitanteId { get; set; }
        public Solicitante Solicitante { get; set; }
        public int CertificacionId { get; set; }
        public Certificacion Certificacion { get; set; }
        public String RolDesempena { get; set; }
        public String Comentarios { get; set; }


        public bool EsValido(ref string mensaje)
        {


            if (string.IsNullOrWhiteSpace(RolDesempena))
            {
                mensaje = "El rol es requerido";
                return false;
            
            }



            return true;

        }

    }
}
