using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Proyecto;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Proyectos
{
   public class ProyectoCriterioAplicacionService : IProyectoCriterioAplicacionService
    {

        private readonly IRepositorio<ProyectoCriterio> _proyectoCriterioRepositorio;

        public ProyectoCriterioAplicacionService(IRepositorio<ProyectoCriterio> proyectoCriterioRepositorio)
        {
            _proyectoCriterioRepositorio = proyectoCriterioRepositorio;
        }

        public void AgregarProyecto(ProyectoCriterioAgregarDto nuevoProyectoCriterio)
        {
            var proyectoCritero = nuevoProyectoCriterio.MapTo<ProyectoCriterio>();


            string mensaje = "";

            if (!proyectoCritero.EsValido(ref mensaje))
            {
                nuevoProyectoCriterio.Respuesta = mensaje;
                return;

            }

            _proyectoCriterioRepositorio.Agregar(proyectoCritero);
            _proyectoCriterioRepositorio.UnitOfWork.Commit();
        }

        public List<Dtos.Proyecto.ProyectoCriterioDto> ObtenerProyectosCriteriosActivos()
        {
            var proyectoCriterio = _proyectoCriterioRepositorio.ObtenerTodos().ToList();

            return ProyectoCriterioDto.MapList(proyectoCriterio);
        }
    }
}
