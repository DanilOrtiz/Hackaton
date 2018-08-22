using Hackaton.Infraestructure.Core;
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

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
