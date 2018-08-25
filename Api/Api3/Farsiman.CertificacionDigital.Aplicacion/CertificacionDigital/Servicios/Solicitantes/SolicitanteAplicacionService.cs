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
                return;

            }

            _solicitanteRepositorio.Agregar(solicitante);
            _solicitanteRepositorio.UnitOfWork.Commit();
        }


        public List<SolicitanteDto> ObtenerSolicitantesActivos()
        {
            var solicitante = _solicitanteRepositorio.ObtenerTodos();

            return (from s in solicitante
                    select new SolicitanteDto
                    {
                        Descripcion = s.Descripcion,
                        ID = s.Id,
                        Correo = s.Correo,
                        Telefono = s.Telefono,
                        Departamento_ID = s.Departamento_ID,
                        Departamento = s.Departamento,
                        Usuario_ID = s.Usuario_ID,
                        Usuario = s.Usuario                        
                    }).ToList();
        }
    }
}
