using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Hackaton.Dominio.Core.Repositorios
{
    public interface IRepositorio<TEntidad>
    {
        void Agregar(List<TEntidad> datos);
        void Agregar(TEntidad dato);
        void Eliminar(int id);
        void Eliminar(TEntidad dato);
        List<TEntidad> ObtenerTodos();
        TEntidad ObtenerPorID(int id);
        IUnitOfWork UnitOfWork { get; }
        TEntidad FirstOrDefault(Expression<Func<TEntidad, bool>> query);
        List<TEntidad> Where(Expression<Func<TEntidad, bool>> query);
        IQueryable<TEntidad> AsQueryable();


    }
}
