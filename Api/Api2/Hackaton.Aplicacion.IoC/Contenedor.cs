using Hackaton.Infraestructura.Hackaton;
using Hackaton.Infraestructura.Core;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackaton.Infraestructure;
using Hackaton.Dominio.Core.Repositorios;
using Hackaton.Application.Services;

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
            UnityContainer.RegisterType<IHackatonService, HackatonService>();
            //UnityContainer.RegisterType<ICifradoServicio, CifradoShaServicio>();
            //UnityContainer.RegisterType<IUsuarioAplicacionService, UsuariosAplicacionesService>();
            //UnityContainer.RegisterType<ILoginServiceAplicacion, LoginServiceAplicacion>();
            //UnityContainer.RegisterType<ILoginServiceDominio, LoginServiceDominio>();

            //UnityContainer.RegisterType<ISprintAplicacionService, SprintAplicacionService>();

            //UnityContainer.RegisterType<IUENSAplicacionService, UENSAplicacionesService>();

            //UnityContainer.RegisterType<IDepartamentoAplicacionService, DepartamentoAplicacionService>();

            //UnityContainer.RegisterType<IPoyectoAplicacionService, ProyectoAplicacionService>();


            //UnityContainer.RegisterType<ISolicitanteAplicacionService, SolicitanteAplicacionService>();


            //UnityContainer.RegisterType<ICertificacionAplicacionService, CertificacionAplicacionService>();

            //UnityContainer.RegisterType<IProyectoCriterioAplicacionService, ProyectoCriterioAplicacionService>();

            //UnityContainer.RegisterType<ICertificacionAplicacionCriterioService, CertificacionAplicacionCriteriosService>();


            //UnityContainer.RegisterType<ICertificacionSolicitanteAplicacionService, CertificacionSolicitanteService>();
            MapeoObjetos.ConfigurarMapeos();
        }

        public static TObjeto Resolve<TObjeto>()
        {
            return UnityContainer.Resolve<TObjeto>();
        }
    }
}
