using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Proyectos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Sprints;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;


namespace Farsiman.CertificacionDigital.Dominio.Test.Proyectos
{
    [TestClass]
    public class ProyectosTest
    {
        private readonly IProyectoServicioDominio _proyectoServicioDomino = new ProyectoServicioDominio();

        [TestMethod]
        public void El_sprint_debe_de_estar_activo()
        {

            //Arrange
            Sprint sprint = new Sprint()
            {
                Activo = false
            };

            Proyecto proyecto = new Proyecto()
            {
                Sprint = sprint

            };
            
            //Act
            string mensaje;
            var respuesta = _proyectoServicioDomino.SonDatosValidos(proyecto, out mensaje);

            //Assert
            Assert.AreEqual(respuesta, false);
            Assert.AreEqual(mensaje, "El Sprint del proyecto no se encuentra activo.");
        }


        [TestMethod]
        public void El_sprint_no_se_encuentra_finalizado()
        {

            //Arrange
            Sprint sprint = new Sprint()
            {
                Activo = true,
                FechaFin = DateTime.Now.Date
            };

            Proyecto proyecto = new Proyecto()
            {
                Sprint = sprint

            };

            //Act
            string mensaje;
            var respuesta = _proyectoServicioDomino.SonDatosValidos(proyecto, out mensaje);

            //Assert
            Assert.AreEqual(respuesta, true);
        }



    }
}
