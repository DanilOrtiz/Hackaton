﻿using Farsiman.CertificacionDigital.Aplicacion.Core;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Sprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Proyecto
{
    public class ProyectoDto : BaseDto<ProyectoDto>
    {
        public string Descripcion { get; set; }
        public string CodigoJira { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int SprintId { get; set; }
        public virtual Sprint Sprint { get; set; }
        public string Tipo { get; set; }
        public int ?UsuarioModifica { get; set; }
        //public virtual Usuario Usuario { get; set; }
        public DateTime ?FechaModifica { get; set; }
        public decimal DiasEstimado { get; set; }
        public string Comentario { get; set; }
        public int DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }
        public int SolicitanteId { get; set; }
    }
}