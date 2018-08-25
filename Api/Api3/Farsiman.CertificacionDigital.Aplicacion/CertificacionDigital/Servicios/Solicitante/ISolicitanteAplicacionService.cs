using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Solicitantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Solicitantes
{
    public interface ISolicitanteAplicacionService
    {
        void AgregarSolicitante(SolicitanteAgregarDto solicitanteNuevo);
        List<SolicitanteDto> ObtenerSolicitantesActivos();
        void EditarSolicitante(SolicitanteEditDto solicitanteEdit);

    }
}
