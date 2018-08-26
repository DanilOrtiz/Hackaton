using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using TechTalk.SpecFlow;

namespace Farsiman.CertificacionDigital.Dominio.Test
{
    [Binding]
    public class LoginSteps
    {
        SHA1 sha = new SHA1CryptoServiceProvider();

        [Given(@"una clave ingresada por el usuario (.*)")]
        public void DadoUnaClaveIngresadaPorElUsuario(string clave)
        {
            var usuario = new Usuario();

            if (clave != "")
            {
                usuario.Clave = sha.ComputeHash(System.Text.UTF8Encoding.ASCII.GetBytes(clave));
            }
            
            ScenarioContext.Current.Add("usuario", usuario);
      
        }

        [Given(@"el estado del usuario (.*)")]
        public void DadoElEstadoDelUsuario(string estado)
        {
            ((Usuario)ScenarioContext.Current["usuario"]).Activo=bool.Parse(estado);
        }
        
        [Given(@"la clave que tiene configurada el usuario (.*)")]
        public void DadoLaClaveQueTieneConfiguradaElUsuario(string claveActual)
        {
            ScenarioContext.Current.Add("ClaveActual", claveActual);
        }

        [When(@"él usuario desea ingresar")]
        public void CuandoElUsuarioDeseaIngresar()
        {
            ILoginServiceDominio _loginServicioDominio = new LoginServiceDominio();
            var usuario = (Usuario)ScenarioContext.Current["usuario"];
            var claveEncriptada = sha.ComputeHash(System.Text.UTF8Encoding.ASCII.GetBytes(ScenarioContext.Current["ClaveActual"].ToString()));
            string mensaje;

            bool respuesta = _loginServicioDominio.SonCredencialesValidas(usuario, claveEncriptada,out mensaje);

            ScenarioContext.Current.Add("respuesta", respuesta.ToString());
            ScenarioContext.Current.Add("mensaje", mensaje);
        }


        [Then(@"el resultado sera (.*)")]
        public void EntoncesElResultadoSera(string esperado)
        {
            var respuesta = ScenarioContext.Current["respuesta"];

            Assert.AreEqual(esperado, respuesta);
        }
        
        [Then(@"El mensaje es (.*)")]
        public void EntoncesElMensajeEs(string esperado)
        {
            var mensaje = ScenarioContext.Current["mensaje"];
            Assert.AreEqual(esperado, mensaje);
        }
    }
}
