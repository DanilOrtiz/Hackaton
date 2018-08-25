using Farsiman.CertificacionDigital.Infraestructura.CertificacionDigital.Mapeos;
using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Infraestructure.Maps
{
    class EmpresaCategoriaMap : BaseMap<EmpresaCategoria>
    {
        public EmpresaCategoriaMap() : base("Empresa_Categoria","ID")
        {
            Property(x => x.CategoriaID).HasColumnName("Categoria_ID");
            Property(x => x.EmpresaID).HasColumnName("Empresa_ID");

            HasRequired(x => x.Categoria).WithMany(x => x.EmmpresaCategorias).HasForeignKey(x => x.CategoriaID);
            HasRequired(x => x.Empresa).WithMany(x => x.EmmpresaCategorias).HasForeignKey(x => x.EmpresaID);


        }
    }
}