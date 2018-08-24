using Hackaton.Domain.Entities;
using Hackaton.Infraestructura.Hackaton.Mapeos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    class SucesoCategoriaMap : BaseMap<SucesoCategoria>
    {
        public SucesoCategoriaMap() : base("Suceso_Categoria","ID")
        {
            Property(x => x.CategoriaId).HasColumnName("Categoria_ID");
            Property(x => x.SucesoId).HasColumnName("Suceso_Id");

            //HasRequired(x => x.Suceso).WithMany(x => x.SucesoCategorias).HasForeignKey(x => x.SucesoId);
            //HasRequired(x => x.Categoria).WithMany(x => x.SucesoCategorias).HasForeignKey(x => x.CategoriaId);

        }
    }
}