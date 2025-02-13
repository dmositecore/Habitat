﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TriggerAnOutcomeOnCustomerRegistrationFeature : Xunit.IUseFixture<TriggerAnOutcomeOnCustomerRegistrationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Trigger an outcome on customer registration.feature"
#line hidden
        
        public TriggerAnOutcomeOnCustomerRegistrationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Trigger an outcome on customer registration", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(TriggerAnOutcomeOnCustomerRegistrationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Trigger an outcome on customer registration")]
        [Xunit.TraitAttribute("Description", "Trigger an outcome on customer registration_UC1_Default registration outcome")]
        public virtual void TriggerAnOutcomeOnCustomerRegistration_UC1_DefaultRegistrationOutcome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Trigger an outcome on customer registration_UC1_Default registration outcome", new string[] {
                        "InDesgin"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 7
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table1, "When ");
#line 10
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("User clicks END VISIT button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Outcome"});
            table2.AddRow(new string[] {
                        "Marketing Lead"});
#line 13
 testRunner.Then("Experince Profile-->Activity outcomes field equals to", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Trigger an outcome on customer registration")]
        [Xunit.TraitAttribute("Description", "Trigger an outcome on customer registration_UC2_Custom registration outcome")]
        public virtual void TriggerAnOutcomeOnCustomerRegistration_UC2_CustomRegistrationOutcome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Trigger an outcome on customer registration_UC2_Custom registration outcome", new string[] {
                        "InDesgin"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "RegisterOutcome"});
            table3.AddRow(new string[] {
                        "Sales Lead"});
#line 21
 testRunner.Given("Habitat/Accounts analytics/RegisterOutcome field value defined:", ((string)(null)), table3, "Given ");
#line 24
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table4.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 25
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table4, "When ");
#line 28
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("User clicks END VISIT button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Outcome"});
            table5.AddRow(new string[] {
                        "Sales Lead"});
#line 31
 testRunner.Then("Experince Profile-->Activity outcomes field equals to", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Trigger an outcome on customer registration")]
        [Xunit.TraitAttribute("Description", "Trigger an outcome on customer registration_UC3_None registration outcome")]
        public virtual void TriggerAnOutcomeOnCustomerRegistration_UC3_NoneRegistrationOutcome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Trigger an outcome on customer registration_UC3_None registration outcome", new string[] {
                        "InDesgin"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "RegisterOutcome"});
            table6.AddRow(new string[] {
                        "None"});
#line 38
 testRunner.Given("Habitat/Accounts analytics/RegisterOutcome field value defined:", ((string)(null)), table6, "Given ");
#line 41
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table7.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 42
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table7, "When ");
#line 45
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("User clicks END VISIT button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Outcome"});
            table8.AddRow(new string[] {
                        "Empty"});
#line 48
 testRunner.Then("Experince Profile-->Activity outcomes field equals to", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TriggerAnOutcomeOnCustomerRegistrationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TriggerAnOutcomeOnCustomerRegistrationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
