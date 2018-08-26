using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Proyectos
{
    public interface IProyectoCriterioAplicacionService
    {
        void AgregarProyecto(ProyectoCriterioAgregarDto nuevoProyectoCriterio);
        List<ProyectoCriterioDto> ObtenerProyectosCriteriosActivos();
    }
}
