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
   public class CertificacionAplicacionService : ICertificacionAplicacionService
    {
        private readonly IRepositorio<Certificacion> _certificacionRepositorio;


        public CertificacionAplicacionService(IRepositorio<Certificacion> certificacionRepositoro)
        {

            _certificacionRepositorio = certificacionRepositoro;
        }

        public void AgregarCertificacion(CertificacionAgregarDto nuevaCertificacion)
        {
            var certificacion = nuevaCertificacion.MapTo<Certificacion>();

            string mensaje = "";

            if (!certificacion.EsValido(ref mensaje))
            {
                nuevaCertificacion.Respuesta = mensaje;
                return;

            }

            _certificacionRepositorio.Agregar(certificacion);
            _certificacionRepositorio.UnitOfWork.Commit();
            

        }

        public List<CertificacionDto> ObtenerCertificacionActivas()
        {
            var certificacion = _certificacionRepositorio.ObtenerTodos().ToList();

            return CertificacionDto.MapList(certificacion);
        }
    }
}
