using Farsiman.CertificacionDigital.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Permisos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital.Mapeos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.UENS;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Sprints;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;
using Hackaton.Infraestructure.Maps;
using Hackaton.Domain.Entities;

namespace Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital
{
    public class CertificacionDigitalUnitOfWork : BaseUnitOfWork 
    {
        public CertificacionDigitalUnitOfWork()
            : base("CertificacionDigitalContext")
        { 
        
        }

        ////public DbSet<Perfil> Perfiles { get; set; }
        //public DbSet<PerfilPermiso> PerfilesPermisos { get; set; }
        //public DbSet<Permiso> Permisos { get; set; }
        ////public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<UEN> UENS { get; set; }
        //public DbSet<Sprint> Sprints { get; set; }
        //public DbSet<Departamento> Departamentos { get; set; }
        //public DbSet<Solicitante> Solicitante { get; set; }
        //public DbSet<Proyecto> Proyecto { get; set; }
        //public DbSet<Certificacion> Certificacion { get; set; }
        //public DbSet<ProyectoCriterio> ProyectoCriterio { get; set; }
        //public DbSet<CertificacionCriterio> CertificacionCriterio { get; set; }
        //public DbSet<CertificacionSolicitante> CertificacionSolicitante { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<EmpresaCategoria> EmpresaCategoria { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Perfil> Perfil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new CiudadMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new PerfilMap());
            //modelBuilder.Configurations.Add(new SucesoCategoriaMap());
            //modelBuilder.Configurations.Add(new SucesoComentarioMap());
            //modelBuilder.Configurations.Add(new SucesoMultimediaMap());
            //modelBuilder.Configurations.Add(new SucesoMap());
            //modelBuilder.Configurations.Add(new SucesoMultimediaTipoMap());
            //modelBuilder.Configurations.Add(new SucesoValoracionMap());
            //modelBuilder.Configurations.Add(new SucesoValoracionTipoMap());
            //modelBuilder.Configurations.Add(new UsuarioMap());
            //modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new EmpresaCategoriaMap());
            modelBuilder.Configurations.Add(new EstadoMap());

            //modelBuilder.Configurations.Add(new PerfilesMap());
            //modelBuilder.Configurations.Add(new PerfilPermisoMap());
            //modelBuilder.Configurations.Add(new PermisosMap());
            //modelBuilder.Configurations.Add(new UsuariosMap());
            //modelBuilder.Configurations.Add(new UENSMap());
            //modelBuilder.Configurations.Add(new SprintsMap());
            //modelBuilder.Configurations.Add(new DepartamentosMap());
            //modelBuilder.Configurations.Add(new SolicitanteMapeo());
            //modelBuilder.Configurations.Add(new ProyectoMap());
            //modelBuilder.Configurations.Add(new CertificacionMapeo());
            //modelBuilder.Configurations.Add(new ProyectoCriterioMap());
            //modelBuilder.Configurations.Add(new CertificacionCriterioMapeo());
            //modelBuilder.Configurations.Add(new CertificacionSolicitanteMapeo());
        }


    }
}
