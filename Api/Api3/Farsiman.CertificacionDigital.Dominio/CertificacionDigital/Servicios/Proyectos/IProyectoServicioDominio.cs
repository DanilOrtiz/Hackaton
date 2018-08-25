using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Proyectos
{
    public interface IProyectoServicioDominio
    {
        bool SonDatosValidos(Proyecto proyecto, out string mensajeError);
    }
}
