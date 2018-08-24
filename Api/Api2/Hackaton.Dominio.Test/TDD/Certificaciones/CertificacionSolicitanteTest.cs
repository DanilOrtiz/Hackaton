using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Certificaciones;
using Hackaton.Dominio.Hackaton.Certificaciones;
using Hackaton.Dominio.Hackaton.Solicitantes;

namespace Farsiman.CertificacionDigital.Dominio.Test.Certificaciones
{
    [TestClass]
    public class CertificacionSolicitanteTest
    {
        private readonly ICertificacionSolicitanteServiceDominio _certificacionSolicitanteServicio = new CertificacionSolicitanteServiceDominio();

        [TestMethod]
        public void EL_solicitante_no_se_encuentra_activo()
        {

            //Arrenge
            var solicitante = new Solicitante()
            {
                Activo = false
            };
            var certificacionSolicitante = new CertificacionSolicitante();
            certificacionSolicitante.Solicitante = solicitante;

            //Act
            string mensaje;
            var respuesta = _certificacionSolicitanteServicio.SonDatosValidos(certificacionSolicitante, out mensaje);

            //Assert
            Assert.AreEqual(false, respuesta);
            Assert.AreEqual("El solicitante se encuentra desactivado", mensaje);

        }

        [TestMethod]
        public void La_certificacion_no_se_encuentra_activo()
        {
            //Arrenge
            var solicitante = new Solicitante()
            {
                Activo = true
            };

            var certificacion = new Certificacion() {
                Activo = false
            };

            var certificacionSolicitante = new CertificacionSolicitante();
            certificacionSolicitante.Solicitante = solicitante;
            certificacionSolicitante.Certificacion = certificacion;
            //Act
            string mensaje;
            var respuesta = _certificacionSolicitanteServicio.SonDatosValidos(certificacionSolicitante, out mensaje);

            //Assert
            Assert.AreEqual(false, respuesta);
            Assert.AreEqual("La certificación se encuentra desactivado", mensaje);

        }



        [TestMethod]
        public void La_fecha_de_certificacion_debe_ser_mayor_a_la_fecha_actual()
        {
            //Arrenge
            var solicitante = new Solicitante()
            {
                Activo = true
            };

            var certificacion = new Certificacion()
            {
                Activo = true,
                FechaCertificacion = DateTime.Now.AddDays(-1)
                
            };

            var certificacionSolicitante = new CertificacionSolicitante();
            certificacionSolicitante.Solicitante = solicitante;
            certificacionSolicitante.Certificacion = certificacion;
            //Act
            string mensaje;
            var respuesta = _certificacionSolicitanteServicio.SonDatosValidos(certificacionSolicitante, out mensaje);

            //Assert
            Assert.AreEqual(false, respuesta);
            Assert.AreEqual("La fecha de la certificacion debe ser mayor que la fecha actual", mensaje);

        }



        [TestMethod]
        public void El_solicitante_ya_tiene_una_certificacion_agentada_duarente_esa_fecha()
        {
            //Arrenge
            var solicitante = new Solicitante()
            {
                Activo = true
            };

            var certificacion = new Certificacion()
            {
                Activo = true,
                FechaCertificacion = DateTime.Now.AddDays(-1)

            };

            var certificacionSolicitante = new CertificacionSolicitante();
            certificacionSolicitante.Solicitante = solicitante;
            certificacionSolicitante.Certificacion = certificacion;
            //Act
            string mensaje;
            var respuesta = _certificacionSolicitanteServicio.SonDatosValidos(certificacionSolicitante, out mensaje);

            //Assert
            Assert.AreEqual(false, respuesta);
            Assert.AreEqual("La fecha de la certificacion debe ser mayor que la fecha actual", mensaje);

        }




    }
}
