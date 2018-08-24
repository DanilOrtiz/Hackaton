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
namespace Farsiman.CertificacionDigital.Dominio.Test.BDD.Logins
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Login", Description="\tPruebas para iniciar sesión por parte de un usuario", SourceFile="BDD\\Logins\\Login.feature", SourceLine=2)]
    public partial class LoginFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("es-ES"), "Login", "\tPruebas para iniciar sesión por parte de un usuario", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void Login(string estado, string clave, string resultado, string claveActual, string mensaje, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Login"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given(string.Format("una clave ingresada por el usuario {0}", clave), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 9
 testRunner.And(string.Format("el estado del usuario {0}", estado), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line 10
 testRunner.And(string.Format("la clave que tiene configurada el usuario {0}", claveActual), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line 11
 testRunner.When("él usuario desea ingresar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 12
 testRunner.Then(string.Format("el resultado sera {0}", resultado), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line 13
 testRunner.And(string.Format("El mensaje es {0}", mensaje), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login, false", new string[] {
                "Login"}, SourceLine=16)]
        public virtual void Login_False()
        {
#line 7
this.Login("false", "", "False", "", "El usuario no está activo", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login, true", new string[] {
                "Login"}, SourceLine=16)]
        public virtual void Login_True()
        {
#line 7
this.Login("true", "1234", "True", "1234", "OK", ((string[])(null)));
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