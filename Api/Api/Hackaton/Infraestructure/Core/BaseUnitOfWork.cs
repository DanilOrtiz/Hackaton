namespace Hackaton.Infraestructure.Core
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.Validation;
    using Domain.Core.Repositorios;

    public class BaseUnitOfWork : DbContext, IEntityUnitOfWork
    {
        public BaseUnitOfWork(string cadenaConexion)
            : base(cadenaConexion)
        {
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public virtual void Commit()
        {
            var transaccion = Database.BeginTransaction();
            try
            {
                SaveChanges();
                transaccion.Commit();
                transaccion.Dispose();
            }
            catch (DbEntityValidationException ex)
            {
                transaccion.Rollback();
                transaccion.Dispose();

               throw ex;
            }
        }

        public DbSet<TEntidad> ObtenerDbSet<TEntidad>() where TEntidad : class
        {
            return Set<TEntidad>();
        }

        public IRepositorio<TEntidad> Repositorio<TEntidad>() where TEntidad : class
        {
            return Repositorio<TEntidad>();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }

        bool IUnitOfWork.SaveChanges()
        {
            SaveChanges();
               return true;
        }
    }
}
