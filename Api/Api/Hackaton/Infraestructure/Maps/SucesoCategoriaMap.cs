using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class SucesoCategoriaMap : EntidadMap<SucesoCategoria>
    {
        public SucesoCategoriaMap(string tablaNombre) : base(tablaNombre)
        {
            Property(x => x.CategoriaId);
            Property(x => x.SucesoId);

            HasRequired(x => x.Suceso).WithMany(x => x.SucesoCategorias).HasForeignKey(x => x.SucesoId);
            HasRequired(x => x.Categoria).WithMany(x => x.SucesoCategorias).HasForeignKey(x => x.CategoriaId);

        }
    }
}