using Farsiman.CertificacionDigital.Aplicacion.Hackaton.Dtos;
using Hackaton.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Application.Services
{
    public interface IHackatonService
    {
        List<CiudadDto> ObtenerCiudades();
        List<CategoriaDto> ObtenerCategorias();
        List<PerfilDto> ObtenerPerfiles();
        List<EstadoDto> ObtenerEstados();
        List<SucesoDto> ObtenerSucesos();
        List<SucesoDto> ObtenerTopDeSucesos(int top);
        List<SucesoDto> ObtenerTopDeSucesosMenorDeId(int top,int SucesoId);
        List<EmpresaDto> ObtenerEmpresas();
        List<EmpresaCategoriaDto> ObtenerEmpresasPorCategoria();
        List<UsuarioDto> ObtenerUsuarios();
        UsuarioDto AgregarUsuario(UsuarioDto nuevoUsuario);
        UsuarioDto EditarUsuario(UsuarioDto usuarioEdit);
    }
}
