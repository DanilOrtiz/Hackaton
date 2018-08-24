
namespace Hackaton.Application.IoC
{
    public static class MapeoObjetos
    {
        public static void ConfigurarMapeos()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfiles("Farsiman.CertificacionDigital.Aplicacion");
            });
        }

    }
}
