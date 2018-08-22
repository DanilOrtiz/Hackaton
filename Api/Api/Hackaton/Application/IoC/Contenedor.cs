using Farsiman.CertificacionDigital.IoC;
using Hackaton.Domain.Core.Repositorios;
using Hackaton.Infraestructure;
using Hackaton.Infraestructure.Core;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hackaton.Application.IoC
{
    public static class Contenedor
    {
        public static UnityContainer UnityContainer;

        static Contenedor()
        {
            UnityContainer = new UnityContainer();
            UnityContainer.RegisterType<IEntityUnitOfWork, HackatonUnitOfWork>();
            UnityContainer.RegisterType(typeof(IRepositorio<>), typeof(Repositorio<>));
            MapeoObjetos.ConfigurarMapeos();
        }

        public static TObjeto Resolve<TObjeto>()
        {
            return UnityContainer.Resolve<TObjeto>();
        }
    }
}
