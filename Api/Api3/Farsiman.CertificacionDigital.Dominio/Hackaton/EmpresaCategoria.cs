using Hackaton.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class EmpresaCategoria:Entidad
    {
        public int CategoriaID { get; set; }
        public int EmpresaID { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}