using Hackaton.Aplicacion.Core;
using Hackaton.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Application.Dtos
{
    public class EmpresaCategoriaDto : BaseDto<EmpresaCategoriaDto>
    {
        public int CategoriaID { get; set; }
        public int EmpresaID { get; set; }

        public EmpresaDto Empresa { get; set; }
        public CategoriaDto Categoria { get; set; }
    }
}
