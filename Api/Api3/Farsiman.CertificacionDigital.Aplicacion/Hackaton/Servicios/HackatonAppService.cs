using Hackaton.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos;
using Hackaton.Application.Dtos;

namespace Farsiman.CertificacionDigital.Aplicacion.Hackaton.Servicios
{
    public class HackatonAppService : IHackatonService
    {
        public List<CategoriaDto> ObtenerCategorias()
        {
            throw new NotImplementedException();
        }

        public List<CiudadDto> ObtenerCiudades()
        {
            throw new NotImplementedException();
        }

        public List<EmpresaDto> ObtenerEmpresas()
        {
            throw new NotImplementedException();
        }

        public List<EmpresaCategoriaDto> ObtenerEmpresasPorCategoria()
        {
            throw new NotImplementedException();
        }

        public List<EstadoDto> ObtenerEstados()
        {
            throw new NotImplementedException();
        }

        public List<PerfilDto> ObtenerPerfiles()
        {
            throw new NotImplementedException();
        }

        public List<SucesoDto> ObtenerSucesos()
        {
            throw new NotImplementedException();
        }

        public List<SucesoDto> ObtenerTopDeSucesos(int top)
        {
            throw new NotImplementedException();
        }

        public List<SucesoDto> ObtenerTopDeSucesosMenorDeId(int top, int SucesoId)
        {
            throw new NotImplementedException();
        }
    }
}
