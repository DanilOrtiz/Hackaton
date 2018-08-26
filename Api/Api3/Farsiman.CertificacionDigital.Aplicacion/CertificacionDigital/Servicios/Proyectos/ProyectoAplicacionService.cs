using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Proyecto;


namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Proyectos
{
   public class ProyectoAplicacionService : IPoyectoAplicacionService
    {

        private readonly IRepositorio<Proyecto> _proyectoRepositorio;

        public ProyectoAplicacionService(IRepositorio<Proyecto> proyectoRepositorio)
        {
            _proyectoRepositorio = proyectoRepositorio;

        }


        public void AgregarProyecto(ProyectoAgregarDto nuevoProyecto)
        {
            var proyecto = nuevoProyecto.MapTo<Proyecto>();

            string mensaje = "";

            if (!proyecto.EsValido(ref mensaje))
            {
                nuevoProyecto.Respuesta = mensaje;
                return;

            }

            _proyectoRepositorio.Agregar(proyecto);


            _proyectoRepositorio.UnitOfWork.Commit();

        }


        public List<ProyectoDto> ObtenerProyectosActivos()
        {
            var proyecto = _proyectoRepositorio.ObtenerTodos().ToList();

            return ProyectoDto.MapList(proyecto);

        }
    }
}
