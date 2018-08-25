using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Certificaciones;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;
using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Certificaciones
{
    public class CertificacionSolicitanteService : ICertificacionSolicitanteAplicacionService

    {

        private readonly IRepositorio<CertificacionSolicitante> _certificacionRepositorio;

        public CertificacionSolicitanteService(IRepositorio<CertificacionSolicitante> certificacionRepositorio) 
        {
            _certificacionRepositorio = certificacionRepositorio;
        
        }

        public void AgregarCertificacionSolicitante(CertificacionSolicitanteAgregarDto nuevoCertificacionSolicitante)
        {
            var certificacionSolicitante = nuevoCertificacionSolicitante.MapTo<CertificacionSolicitante>();

            string mensaje = "";

            if (certificacionSolicitante.EsValido(ref mensaje))
            {
                nuevoCertificacionSolicitante.Respuesta = mensaje;
            }

            _certificacionRepositorio.Agregar(certificacionSolicitante);
            _certificacionRepositorio.UnitOfWork.Commit();
        }

        public List<CertificacionSolicitanteDto> ObtenerCertificacionSolicitantes()
        {
            var certificacionSolicitante = _certificacionRepositorio.ObtenerTodos().ToList();


            return CertificacionSolicitanteDto.MapList(certificacionSolicitante);
        }

    }
}
