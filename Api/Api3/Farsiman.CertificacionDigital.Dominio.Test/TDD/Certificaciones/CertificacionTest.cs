using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Certificaciones;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Certificaciones;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;

namespace Farsiman.CertificacionDigital.Dominio.Test.Certificaciones
{
    [TestClass]
    public class CertificacionTest
    {

        private readonly ICertificacionServiceDominio _certificacionServicioDomino = new CertificacionServicioDominio();

        [TestMethod]
        public void La_certificacion_no_puede_ser_nula()
        {

            //Arrange
            var certificacion = new Certificacion();
            certificacion = null;

            //Act
            string mensaje;
            var respuesta=_certificacionServicioDomino.SonDatosValidos(certificacion, out mensaje);

            //Assert
            Assert.AreEqual(false, respuesta);

        }

        [TestMethod]
        public void El_proyeto_debe_de_estar_activo()
        {

            //Arrange
            var proyecto = new Proyecto() {
                Activo = false
            };
            var certificacion = new Certificacion();
            certificacion.Proyecto = proyecto;

            //Act
            string mensaje;
            var respuesta = _certificacionServicioDomino.SonDatosValidos(certificacion, out mensaje);

            //Assert
            Assert.AreEqual(false, respuesta);
            Assert.AreEqual("El proyecto para certificar se encuenta desactivado", mensaje);

        }

    }
}
