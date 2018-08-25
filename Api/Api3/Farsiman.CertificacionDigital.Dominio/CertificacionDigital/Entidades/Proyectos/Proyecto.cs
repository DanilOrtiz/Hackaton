using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Sprints;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;


namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos
{
    public class Proyecto : Entidad
    {

        public string Descripcion { get; set; }
        public string CodigoJira { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int SprintID { get; set; }
        public virtual Sprint Sprint { get; set; }
        public string Tipo { get; set; }
        public int ?UsuarioModifica { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime ?FechaModifica { get; set; }
        public decimal DiasEstimado { get; set; }
        public string Comentario { get; set; }
        public int DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }
        public int SolicitanteId { get; set; }
        public virtual Solicitante Solicitante { get; set; }
        public List<Certificacion> Certificacion { get; set; }
        public List<ProyectoCriterio> ProyectoCriterio { get; set; }


        public bool EsValido(ref string mensaje)
        {

            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                mensaje = "La Descripcion es requerida;";
                return false;
            }

            if (string.IsNullOrWhiteSpace(CodigoJira))
            {
                mensaje = "El Codifo de Jira es requerido;";
                return false;
            }

            if (FechaAsignacion.Date < DateTime.Now)
            {
                mensaje = "La fecha de asignacion no puede ser menor a la fecha actual;";
                return false;
            }

            if (SprintID == 0)
            {
                mensaje = "Debe de ingresar el Sprint;";
                return false;
            }

            if (DiasEstimado == 0)
            {
                mensaje = "Debe de ingresar los días estimados. ;";
                return false;
            }


            return true;
        }

    }
}
