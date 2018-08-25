using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Certificaciones
{
    public class CertificacionServicioDominio : ICertificacionServiceDominio
    {

        public bool SonDatosValidos(Certificacion certificacion, out string mensajeError)
        {

            if ( certificacion == null)
            {

                mensajeError = "La certificación no puede ser null";
                return false;
            }

            if (certificacion.Proyecto.Activo == false)
            {

                mensajeError = "El proyecto para certificar se encuenta desactivado";
                return false;

            }



            mensajeError = "Ok";
            return true;
        }
    }
}
