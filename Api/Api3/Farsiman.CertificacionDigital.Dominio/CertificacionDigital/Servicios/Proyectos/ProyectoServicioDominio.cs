using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Proyectos
{
    public class ProyectoServicioDominio : IProyectoServicioDominio
    {
        public bool SonDatosValidos(Proyecto proyecto, out string mensajeError)
        {
            if (proyecto.Sprint.Activo == false)
            {

                mensajeError = "El Sprint del proyecto no se encuentra activo.";
                return false;
            }

            if (proyecto.Sprint.FechaFin > DateTime.Now.Date)
            {
                mensajeError = "El Sprint ya se encuentra finalizado. ";
                return false;

            }

            mensajeError = "";
            return true;
        }
    }
}
