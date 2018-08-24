using Hackaton.Application.Services;
using Hackaton.Domain.Core.Repositorios;
using Hackaton.Infraestructure;
using Hackaton.Infraestructure.Core;
using Microsoft.Practices.Unity;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;

namespace Hackaton.App_Start
{
    public class Contenedor
    {

        //public static IKernel Kernel { get; set; }
        public static UnityContainer UnityContainer;

        static Contenedor()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfiles("Hackaton");
            });
        }

        public static void RegistrarDependencias(IKernel kernel)
        {
            //kernel.Bind(typeof(IRepositorio<>)).To(typeof(Repositorio<>));
            // kernel.Bind<IUnitOfWork, IEntityUnitOfWork>().To<HackatonUnitOfWork>()
            //     .WithConstructorArgument("repositorioType", x => { return typeof(Repositorio<>); });

            // kernel.Bind<IHackatonService>().To<HackatonService>();
            // //kernel.Bind<IReporteParaleloProcedimientoAppService>().To<ReporteParaleloProcedimientoAppService>();
            // //kernel.Bind<ISQLServerManagementAppService>().To<SQLServerManagementAppService>();
            // Kernel = kernel;

            UnityContainer.RegisterType<IEntityUnitOfWork, HackatonUnitOfWork>();
            UnityContainer.RegisterType(typeof(IRepositorio<>), typeof(Repositorio<>));
            UnityContainer.RegisterType<IHackatonService, HackatonService>();
        }

        //public static T Get<T>()
        //{
        //    return Kernel.Get<T>();
        //}

        public static TObjeto Resolve<TObjeto>()
        {
            return UnityContainer.Resolve<TObjeto>();
        }

    }
}