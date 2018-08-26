using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Solicitantes;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;
using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Solicitantes
{
    public class SolicitanteAplicacionService : ISolicitanteAplicacionService
    {

        private readonly IRepositorio<Solicitante> _solicitanteRepositorio;

        public SolicitanteAplicacionService(IRepositorio<Solicitante> solicitanteRepositorio)
        {
            _solicitanteRepositorio = solicitanteRepositorio;        
        }



        public void AgregarSolicitante(SolicitanteAgregarDto solicitanteNuevo)
        {
            var solicitante = solicitanteNuevo.MapTo<Solicitante>();

            string mensaje = "";

            if (!solicitante.EsValido(ref mensaje))
            {
                solicitanteNuevo.Respuesta = mensaje;
                solicitanteNuevo.RespuestaTipo = Core.RespuestaTipo.Validacion;
                return;

            }
                      
            _solicitanteRepositorio.Agregar(solicitante);
            _solicitanteRepositorio.UnitOfWork.Commit();
            solicitanteNuevo.RespuestaTipo = Core.RespuestaTipo.Ok;
            solicitanteNuevo.Respuesta = "Ok";
        }

        public void EditarSolicitante(SolicitanteEditDto solicitanteEdit)
        {
            var solicitante = (from s in _solicitanteRepositorio.AsQueryable()
                               where s.Id == solicitanteEdit.Id
                               select s).FirstOrDefault();

            solicitante.Descripcion = solicitanteEdit.Descripcion;
            solicitante.Correo = solicitanteEdit.Correo;
            solicitante.DepartamentoID = solicitanteEdit.DepartamentoId;
            solicitante.Telefono = solicitanteEdit.Telefono;
            solicitante.Activo = solicitanteEdit.Activo;

            string mensaje = "";
            if (! solicitante.EsValido(ref mensaje))
            {
                solicitanteEdit.Respuesta = mensaje;
                solicitanteEdit.RespuestaTipo = Core.RespuestaTipo.Validacion;
                return;
            }

            
            _solicitanteRepositorio.UnitOfWork.Commit();
            solicitanteEdit.Respuesta = "Ok";
            solicitanteEdit.RespuestaTipo = Core.RespuestaTipo.Ok;
   
        }

        public List<SolicitanteDto> ObtenerSolicitantesActivos()
        {
            var solicitante = _solicitanteRepositorio.ObtenerTodos();

            //return (from s in solicitante
            //        select new SolicitanteDto
            //        {
            //            Descripcion = s.Descripcion,
            //            Id = s.Id,
            //            Correo = s.Correo,
            //            Telefono = s.Telefono,
            //            DepartamentoId = s.DepartamentoID,
            //            Departamento = s.Departamento,
            //            UsuarioId = s.UsuarioId,
            //            Usuario = s.Usuario                        
            //        }).ToList();

            return SolicitanteDto.MapList(solicitante);
        }
    }
}
