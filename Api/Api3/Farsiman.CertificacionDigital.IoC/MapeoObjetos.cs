
namespace Hackaton.Aplicacion.IoC
{
    public static class MapeoObjetos
    {
        public static void ConfigurarMapeos()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfiles("Hackaton.Aplicacion");
            });
        }

    }
}
