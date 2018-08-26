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
    public class CertificacionAplicacionCriteriosService : ICertificacionAplicacionCriterioService

    {
        private readonly IRepositorio<CertificacionCriterio> _certificacionCriterioRepositorio;


        public CertificacionAplicacionCriteriosService(IRepositorio<CertificacionCriterio> certificacionCriterioRepositorio)
        {
            _certificacionCriterioRepositorio = certificacionCriterioRepositorio;
        
        }



        public void AgregarCertificacionCriterio(CertificacionCriterioAgregarDTO nuevoCertificacionCriterio)
        {
            var certificacionCriterio = nuevoCertificacionCriterio.MapTo<CertificacionCriterio>();

            string mensaje = "";

            if (certificacionCriterio.EsValido(ref mensaje))
            {
               nuevoCertificacionCriterio.Respuesta= mensaje;
            }

            _certificacionCriterioRepositorio.Agregar(certificacionCriterio);
            _certificacionCriterioRepositorio.UnitOfWork.Commit();
            
        }

        public List<CertificacionCriterioDto> ObtenerCertificacionCriterios()
        {
                         
          var certificacionC= _certificacionCriterioRepositorio.ObtenerTodos().ToList();


            return CertificacionCriterioDto.MapList(certificacionC);
        }
    }
}
