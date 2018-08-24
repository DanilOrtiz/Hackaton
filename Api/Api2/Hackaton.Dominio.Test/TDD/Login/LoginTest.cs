using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios;
using Hackaton.Dominio.Hackaton.Usuarios;
using System.Security.Cryptography;


namespace Farsiman.CertificacionDigital.Dominio.Test.Login
{
    [TestClass]
    public class LoginTest
    {
        private readonly ILoginServiceDominio _loginServicioDominio = new LoginServiceDominio() ;

        [TestMethod]
        public void El_usuario_no_debe_ser_nulo()
        {
            //Arrange

            //Act
            string mensaje;

            _loginServicioDominio.SonCredencialesValidas(null, null, out mensaje);

            //Assert
            Assert.AreEqual(mensaje,"El usuario es requerido");
            
        }

        [TestMethod]
        public void El_usuario_no_debe_estar_desactivo()
        {
            //Arrange
            Usuario usuario = new Usuario()
            {
                Activo = false

            };

            //Act
            string mensaje;
            _loginServicioDominio.SonCredencialesValidas(usuario, null, out mensaje);

            //Assert
            Assert.AreEqual(mensaje, "El usuario no está activo");

        }

        [TestMethod]
        public void La_clave_del_usuario_no_debe_ser_null()
        {
            //Arrange
            Usuario usuario = new Usuario()
            {
                Activo = true

            };

            //Act
            string mensaje;
            _loginServicioDominio.SonCredencialesValidas(usuario, null, out mensaje);

            //Assert
            Assert.AreEqual(mensaje, "La clave es requerida");

        }

        [TestMethod]
        public void Las_credenciales_del_usuario_son_validas()
        {
            SHA1 sha = new SHA1CryptoServiceProvider();

            //Arrange
            Usuario usuario = new Usuario()
            {
                Activo = true,
                Clave = sha.ComputeHash(System.Text.UTF8Encoding.ASCII.GetBytes("1234"))

            };

            //Act
            string mensaje;

            
            var textoEnBinario = System.Text.UTF8Encoding.ASCII.GetBytes("1234");

           var respuesta = _loginServicioDominio.SonCredencialesValidas(usuario, sha.ComputeHash(textoEnBinario), out mensaje);

            //Assert
            Assert.AreEqual(respuesta, true);

        }






    }
}
