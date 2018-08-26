using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Aplicacion.Hackaton.Dtos
{
    public enum EnumEstados
    {
         Nuevo = 1,
         EnProceso = 2,
         Realizado = 3,
         Evaluando = 4,
         Finalizado = 5,
         AnuladoPorUsuario = 6
    }
}
