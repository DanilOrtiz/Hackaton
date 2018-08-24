using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Solicitantes;
using Hackaton.Dominio.Hackaton.Solicitantes;
using Hackaton.Dominio.Hackaton.Departamentos;

namespace Farsiman.CertificacionDigital.Dominio.Test.Solicitantes
{
    [TestClass]
    public class SolicitanteTest
    {
        private readonly ISolicitanteServiceDominio solicitanteService = new SolicitanteServiceDominio();

        [TestMethod]
        public void El_departamento_del_solicitante_no_puede_estar_desactivado()
        {
            //Arrange
            Departamento departamento = new Departamento(){
            Activo=false
            
            };


             Solicitante solicitante = new Solicitante(){
             
             Departamento = departamento
             };


            //Act
            string mensaje = "";
            var respuesta=solicitanteService.SonDatosValidos(solicitante,out mensaje);


            //Asset
            Assert.AreEqual(respuesta, false);
            Assert.AreEqual(mensaje, "El departamento se encuentra desativado.");


        }

        [TestMethod]
        public void El_departamento_del_solicitante_esta_activo()
        {
            //Arrange
            Departamento departamento = new Departamento()
            {
                Activo = true

            };


            Solicitante solicitante = new Solicitante()
            {

                Departamento = departamento,
                Correo = "maynor.fuentes@farsiman.com"
            };


            //Act
            string mensaje = "";
            var respuesta = solicitanteService.SonDatosValidos(solicitante, out mensaje);


            //Asset
            Assert.AreEqual(respuesta, true);


        }


        [TestMethod]
        public void El_correo_no_tiene_un_formato_correcto()
        {
            //Arrange
            Departamento departamento = new Departamento()
            {
                Activo = true

            };


            Solicitante solicitante = new Solicitante()
            {

                Departamento = departamento,
                Correo = "maynor.fuentes"
            };


            //Act
            string mensaje = "";
            var respuesta = solicitanteService.SonDatosValidos(solicitante, out mensaje);


            //Asset
            Assert.AreEqual(respuesta, false);
            Assert.AreEqual(mensaje, "El correo no tiene un formato valido.");


        }

    }
}
