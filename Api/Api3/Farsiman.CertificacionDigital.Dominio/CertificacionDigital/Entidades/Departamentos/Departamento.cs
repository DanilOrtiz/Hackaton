using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.UENS;
//using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos
{
   public class Departamento : Entidad 
    {
        public String Descripcion { get; set; }
        public int UENId { get; set; }
        public virtual UEN UEN { get; set; }
        public List<Solicitante> Solicitante { get; set; }
        public List<Proyecto> Proyecto { get; set; }

       public bool EsValido(ref string mensaje)
       {

           if (string.IsNullOrWhiteSpace(Descripcion))
           {

               mensaje = "La descripcion es necesaria;";
               return false;
           }

            if (UENId == 0)
            {
                mensaje = "Se debe de ingresar la unidad de negocio.";
                return false;
            }

           return true;
       }
    }
}
