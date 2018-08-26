using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Departamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Departamentos
{
    public interface IDepartamentoAplicacionService
    {

        void AgregarDepartamento(DepartamentoAgregarDto departamentoNuevo);
        void EditarDepartamento(DepartamentoEditDto departamentoEdit);
        List<DepartamentoDto> ObtenerDepartamentosActivos();
    }
}
