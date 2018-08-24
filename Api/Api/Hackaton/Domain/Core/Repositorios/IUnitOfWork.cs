using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Core.Repositorios
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        IRepositorio<TEntidad> Repositorio<TEntidad>() where TEntidad : class;
        void RollBack();
        bool SaveChanges();
    }
}
