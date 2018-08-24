using Hackaton.Domain.Entities;
using Hackaton.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    public class EmpresaCategoriaMap : EntidadMap<EmpresaCategoria>
    {
        public EmpresaCategoriaMap() : base("Empresa_Categoria")
        {
            Property(x => x.CategoriaID).HasColumnName("Categoria_ID");
            Property(x => x.EmpresaID).HasColumnName("Empresa_ID");

            HasRequired(x => x.Categoria).WithMany(x => x.EmmpresaCategorias).HasForeignKey(x => x.CategoriaID);
            HasRequired(x => x.Empresa).WithMany(x => x.EmmpresaCategorias).HasForeignKey(x => x.EmpresaID);


        }
    }
}