using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.Core
{
    public class BaseDto<TDto>
    {
        public static TDto Map<TEntidad>(TEntidad dato)
        {
            return AutoMapper.Mapper.Map<TDto>(dato);
        }

        public static List<TDto> Map<TEntidad>(List<TEntidad> datos)
        {
            return AutoMapper.Mapper.Map<List<TDto>>(datos);
        }

        public static List<TDto> MapList<TEntidad>(TEntidad dato)
        {
            return AutoMapper.Mapper.Map<List<TDto>>(dato);
        }



        public TEntidad MapTo<TEntidad>()
        {
            return AutoMapper.Mapper.Map<TEntidad>(this);
        }

        public RespuestaTipo RespuestaTipo { get; set; }
        public string Respuesta { get; set; }

    }
}
