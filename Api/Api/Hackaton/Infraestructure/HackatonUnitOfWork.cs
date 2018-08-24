using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using Hackaton.Infraestructure.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure
{
    public class HackatonUnitOfWork : BaseUnitOfWork
    {

        public HackatonUnitOfWork() : base("HackatonContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new CiudadMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new PerfilMap());
            modelBuilder.Configurations.Add(new SucesoCategoriaMap());
            modelBuilder.Configurations.Add(new SucesoComentarioMap());
            modelBuilder.Configurations.Add(new SucesoMultimediaMap());
            modelBuilder.Configurations.Add(new SucesoMap());
            modelBuilder.Configurations.Add(new SucesoMultimediaTipoMap());
            modelBuilder.Configurations.Add(new SucesoValoracionMap());
            modelBuilder.Configurations.Add(new SucesoValoracionTipoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new EmpresaCategoriaMap());




        }
    }
}
