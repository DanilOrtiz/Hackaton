﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Dominio.Core.Repositorios
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void RollBack();
        bool SaveChanges();
    }
}
