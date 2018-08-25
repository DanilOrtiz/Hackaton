using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital;
using Farsiman.CertificacionDigital.Infraestructura.Core;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Cifrado;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Login;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Sprint;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Departamentos;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Proyectos;

using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Solicitantes;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Certificaciones;
using Hackaton.Application.Services;

namespace Farsiman.CertificacionDigital.IoC
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

            UnityContainer.RegisterType<UsuariosAplicacionesService, UsuariosAplicacionesService>();
            UnityContainer.RegisterType<ICifradoServicio, CifradoShaServicio>();
            UnityContainer.RegisterType<IUsuarioAplicacionService, UsuariosAplicacionesService>();
            UnityContainer.RegisterType<ILoginServiceAplicacion, LoginServiceAplicacion>();
            UnityContainer.RegisterType<ILoginServiceDominio, LoginServiceDominio>();

            UnityContainer.RegisterType<ISprintAplicacionService, SprintAplicacionService>();

            UnityContainer.RegisterType<IUENSAplicacionService, UENSAplicacionesService>();

            UnityContainer.RegisterType<IDepartamentoAplicacionService, DepartamentoAplicacionService>();

            UnityContainer.RegisterType<IPoyectoAplicacionService, ProyectoAplicacionService>();


            UnityContainer.RegisterType<ISolicitanteAplicacionService, SolicitanteAplicacionService>();


            UnityContainer.RegisterType<ICertificacionAplicacionService, CertificacionAplicacionService>();

            UnityContainer.RegisterType<IProyectoCriterioAplicacionService, ProyectoCriterioAplicacionService>();

            UnityContainer.RegisterType<ICertificacionAplicacionCriterioService, CertificacionAplicacionCriteriosService>();


            UnityContainer.RegisterType<ICertificacionSolicitanteAplicacionService, CertificacionSolicitanteService>();
            MapeoObjetos.ConfigurarMapeos();
        }

        public static TObjeto Resolve<TObjeto>()
        {
            return UnityContainer.Resolve<TObjeto>();
        }
    }
}
