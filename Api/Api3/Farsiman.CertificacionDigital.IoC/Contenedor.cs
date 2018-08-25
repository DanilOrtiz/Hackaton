
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Cifrado;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Login;
using Hackaton.Application.Services;
using Hackaton.Infraestructura.Core;
using Hackaton.Infraestructura.Hackaton;
using Hackaton.Dominio.Core.Repositorios;
using Hackaton.Dominio.Hackaton.Servicios;

namespace Hackaton.Aplicacion.IoC
{
    public static class Contenedor
    {
        public static UnityContainer UnityContainer;

        static Contenedor()
        {
            UnityContainer = new UnityContainer();
            UnityContainer.RegisterType<IEntityUnitOfWork, CertificacionDigitalUnitOfWork>();
            UnityContainer.RegisterType(typeof(IRepositorio<>), typeof(Repositorio<>));

            UnityContainer.RegisterType<IHackatonService, HackatonService>();
            UnityContainer.RegisterType<ICifradoServicio, CifradoShaServicio>();
            UnityContainer.RegisterType<ILoginServiceAplicacion, LoginServiceAplicacion>();
            UnityContainer.RegisterType<ILoginServiceDominio, LoginServiceDominio>();

            MapeoObjetos.ConfigurarMapeos();
        }

        public static TObjeto Resolve<TObjeto>()
        {
            return UnityContainer.Resolve<TObjeto>();
        }
    }
}
