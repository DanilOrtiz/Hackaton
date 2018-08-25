using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Sprints
{
    public class Sprint : Entidad
    {

        public Sprint()
        {
        }


        public Sprint(int usuarioAgregaId)
            : base(usuarioAgregaId)
        {
        }

        public string Descripcion { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime ?FechaModifica { get; set; }
        public int ?UsuarioModifica { get; set; }
        public List<Proyecto> Proyecto { get; set; }
        //public List<Certificaciones> Certificacion {get; set;}


        public bool EsValido(ref string mensaje)
        {

            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                mensaje = "La Descripcion es requerida;";
                return false;
            }

            if (FechaInicio < DateTime.Now)
            {
                mensaje = "No puede iniciar el Sprint en la fecha " + FechaInicio + ", por que la fecha ya paso;";
                return false;
            }

            if (FechaFin < DateTime.Now)
            {
                mensaje = "No puede finalizar el Sprint en la fecha "+FechaFin+", por que la fecha ya paso;";
                return false;
            }

            if (FechaInicio == FechaFin)
            {
                mensaje = "La fecha de inicio debe de ser diferente que la fecha de finalización del sprint";
                return false;
            }



            return true;
        }

    }
}
