using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Sprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Sprint;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Sprints;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital
{
    public class SprintAplicacionService : ISprintAplicacionService
    {
        private readonly IRepositorio<Sprint> _sprintRepositorio;


        public SprintAplicacionService(IRepositorio<Sprint> sprintRepositorio) {
            _sprintRepositorio = sprintRepositorio;        
        }


        public void AgregarSprint(SprintAgregarDto sprintNuevo)
        {
            var sprint = sprintNuevo.MapTo<Sprint>();

            string mensaje = "";

            if (!sprint.EsValido(ref mensaje))
            {
                sprintNuevo.Respuesta = mensaje;
                sprintNuevo.RespuestaTipo = Core.RespuestaTipo.Excepcion;
                return;
            
            }

            _sprintRepositorio.Agregar(sprint);
            _sprintRepositorio.UnitOfWork.Commit();

            sprintNuevo.Respuesta = "Ok";
            sprintNuevo.RespuestaTipo = Core.RespuestaTipo.Ok;

        }

        public void EditarSprint(SprintEditDto sprintEdit)
        {
            var sprint = (from s in _sprintRepositorio.AsQueryable()
                          where s.Id == sprintEdit.Id
                          select s).FirstOrDefault();

            sprint.Descripcion = sprintEdit.Descripcion;
            sprint.Activo = sprintEdit.Activo;
            sprint.FechaInicio = sprintEdit.FechaInicio;
            sprint.FechaFin = sprintEdit.FechaFin;
            sprint.UsuarioModifica = sprintEdit.UsuarioModifica;
            sprint.FechaModifica = sprintEdit.FechaModifica;

            string mensaje = "";
            if (!sprint.EsValido(ref mensaje))
            {
                sprintEdit.RespuestaTipo = Core.RespuestaTipo.Validacion;
                sprintEdit.Respuesta = mensaje;
                return;
            }

            _sprintRepositorio.UnitOfWork.Commit();
            sprintEdit.RespuestaTipo = Core.RespuestaTipo.Ok;
            sprintEdit.Respuesta = "Ok";

        }

        public List<SprintDto> ObtenerSprintActivos()
        {
            var sprint = _sprintRepositorio.ObtenerTodos();

            return (from s in sprint
                    select new SprintDto
                        {
                            Descripcion = s.Descripcion,
                            FechaInicio = s.FechaInicio,
                            FechaFin = s.FechaFin,
                            Activo = s.Activo,
                            UsuarioModifica = s.UsuarioModifica,
                            FechaModifica = s.FechaModifica,
                            UsuarioAgregaId = 1,
                            FechaAgrega =s.FechaAgrega,
                            Id=s.Id
                                                       
                           
                        }).ToList();

        }
    }
}
