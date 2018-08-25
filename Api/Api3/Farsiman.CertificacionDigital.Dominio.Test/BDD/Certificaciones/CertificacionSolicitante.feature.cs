﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Farsiman.CertificacionDigital.Dominio.Test.BDD.Certificaciones
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CertificacionSolicitante", Description="\tCriterios para crear agregar una\r\n\tcita de certificación para un solicitante det" +
        "erminado", SourceFile="BDD\\Certificaciones\\CertificacionSolicitante.feature", SourceLine=2)]
    public partial class CertificacionSolicitanteFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CertificacionSolicitante.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("es-ES"), "CertificacionSolicitante", "\tCriterios para crear agregar una\r\n\tcita de certificación para un solicitante det" +
                    "erminado", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AgrengandoUnaCertificacionAUnSolicitante(string estadoSolicitante, string estadoCertificacion, string fechaCertificacion, string respuesta, string mensaje, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "CertificacionSolicitant"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Agrengando una certificación a un Solicitante", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given(string.Format("el estado del solicitante es  \'{0}\'", estadoSolicitante), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 10
 testRunner.And("el estado de la certificacion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line 11
 testRunner.And("la fecha de certificacion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line 12
    testRunner.When("se agenda una certificación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 13
 testRunner.Then("el resultado es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line 14
 testRunner.And("el mensaje es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Agrengando una certificación a un Solicitante, Variant 0", new string[] {
                "CertificacionSolicitant"}, SourceLine=17)]
        public virtual void AgrengandoUnaCertificacionAUnSolicitante_Variant0()
        {
#line 8
this.AgrengandoUnaCertificacionAUnSolicitante("false", "false", "", "false", "El solicitante se encuentra desactivado", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Agrengando una certificación a un Solicitante, Variant 1", new string[] {
                "CertificacionSolicitant"}, SourceLine=17)]
        public virtual void AgrengandoUnaCertificacionAUnSolicitante_Variant1()
        {
#line 8
this.AgrengandoUnaCertificacionAUnSolicitante("true", "false", "", "false", "La certificación se encuentra desactivado", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Agrengando una certificación a un Solicitante, Variant 2", new string[] {
                "CertificacionSolicitant"}, SourceLine=17)]
        public virtual void AgrengandoUnaCertificacionAUnSolicitante_Variant2()
        {
#line 8
this.AgrengandoUnaCertificacionAUnSolicitante("true", "true", "2017-11-03", "false", "La fecha de la certificacion debe ser mayor que la fecha actual", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion