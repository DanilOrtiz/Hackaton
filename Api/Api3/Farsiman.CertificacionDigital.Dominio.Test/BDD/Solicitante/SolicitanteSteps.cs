using System;
using TechTalk.SpecFlow;

namespace Farsiman.CertificacionDigital.Dominio.Test.BDD.Solicitante
{
    [Binding]
    public class SolicitanteSteps
    {
        [Given(@"el departamento con su estado (.*)")]
        public void DadoElDepartamentoConSuEstado(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el correo del solicitante (.*)")]
        public void DadoElCorreoDelSolicitante(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"se registra un solicitante")]
        public void CuandoSeRegistraUnSolicitante()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"la respuesta es (.*)")]
        public void EntoncesLaRespuestaEs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"el mensaje es (.*)")]
        public void EntoncesElMensajeEs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
