using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Certificaciones
{
    public class CertificacionSolicitanteServiceDominio : ICertificacionSolicitanteServiceDominio
    {
        public bool SonDatosValidos(CertificacionSolicitante certificacionSolicitante, out string mensaje)
        {

            if (certificacionSolicitante.Solicitante.Activo == false)
            {
                mensaje = "El solicitante se encuentra desactivado";
                return false;
            }

            if (certificacionSolicitante.Certificacion.Activo == false)
            {

                mensaje = "La certificación se encuentra desactivado";
                return false;
            }

            if (certificacionSolicitante.Certificacion.FechaCertificacion < DateTime.Now)
            {

                mensaje = "La fecha de la certificacion debe ser mayor que la fecha actual";
                return false;
            }





            mensaje = "OK";
            return true;
        }
    }
}
