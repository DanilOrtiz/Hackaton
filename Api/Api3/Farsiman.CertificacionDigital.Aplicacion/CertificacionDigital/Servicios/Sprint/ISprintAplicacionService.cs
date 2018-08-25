using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Sprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Sprint
{
    public interface ISprintAplicacionService
    {
        void AgregarSprint(SprintAgregarDto sprintNuevo);
        void EditarSprint(SprintEditDto sprintEdit);
        List<SprintDto> ObtenerSprintActivos();
    }
}
