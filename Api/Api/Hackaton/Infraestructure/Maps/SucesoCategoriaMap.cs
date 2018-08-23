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
        public SucesoCategoriaMap() : base("Suceso_Categoria")
        {
            Property(x => x.CategoriaId).HasColumnName("Categoria_ID");
            Property(x => x.SucesoId).HasColumnName("Suceso_Id");

            HasRequired(x => x.Suceso).WithMany(x => x.SucesoCategorias).HasForeignKey(x => x.SucesoId);
            HasRequired(x => x.Categoria).WithMany(x => x.SucesoCategorias).HasForeignKey(x => x.CategoriaId);

        }
    }
}