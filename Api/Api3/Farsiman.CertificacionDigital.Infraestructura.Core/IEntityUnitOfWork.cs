using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Farsiman.CertificacionDigital.Infraestructura.Core
{
    public interface IEntityUnitOfWork: IUnitOfWork
    {

        DbSet<TEntidad> ObtenerDbSet<TEntidad>() where TEntidad : class;
    }
}
