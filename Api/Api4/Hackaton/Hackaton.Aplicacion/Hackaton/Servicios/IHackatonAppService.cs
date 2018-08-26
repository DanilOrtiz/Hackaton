using Hackaton.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Aplicacion.Hackaton.Servicios
{
   public interface IHackatonAppService
    {
        List<SucesoMultimediaDto> ObtenerSucesosMultimedia();
        List<SucesoComentarioDto> ObtenerSucesosComentarios();
        List<SucesoCategoriaDto> ObtenerSucesoCategorias();
        List<SucesoValoracionDto> ObtenerSucesosValoracion();
        List<SucesoDto> ObtenerSucesos();
        SucesoDto CrearSuceso(SucesoDto suceso);
        SucesoDto AnularSuceso(SucesoDto suceso);
    }
}
