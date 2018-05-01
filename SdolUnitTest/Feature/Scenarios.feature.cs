﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SdolUnitTest.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Scenarios", Description="        As a QA tester I would like to confirm\r\n\t\tThat SEDOL UI responding correc" +
        "tly to possitive and negative scenarios", SourceFile="Feature\\Scenarios.feature", SourceLine=0)]
    public partial class ScenariosFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Scenarios.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenarios", "        As a QA tester I would like to confirm\r\n\t\tThat SEDOL UI responding correc" +
                    "tly to possitive and negative scenarios", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
     testRunner.Given("I am on SEDOL webpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
  testRunner.And("page is fully loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        public virtual void AcceptanceCriteriaScenarios(string sedolNumber, string isValidSedol, string isUserDefined, string errorMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UnitTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Acceptance Criteria Scenarios", @__tags);
#line 10
 this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 11
 testRunner.Given(string.Format("I enter following sedol number {0}", sedolNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.And(string.Format("Is Valid Sedol status is  {0}", isValidSedol), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And(string.Format("Is User Defined status is  {0}", isUserDefined), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("I press Submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then(string.Format("I receive the message  {0}", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, 1234567", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_1234567()
        {
#line 10
 this.AcceptanceCriteriaScenarios("1234567", "False", "False", "Checksum digit does not agree with the first 6 characters", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, 9123451", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_9123451()
        {
#line 10
 this.AcceptanceCriteriaScenarios("9123451", "False", "True", "Checksum digit does not agree with the first 6 characters", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, 9ABCDE8", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_9ABCDE8()
        {
#line 10
 this.AcceptanceCriteriaScenarios("9ABCDE8", "False", "True", "Checksum digit does not agree with the first 6 characters", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, Null", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_Null()
        {
#line 10
 this.AcceptanceCriteriaScenarios("Null", "False", "False", "Input string was not 7-characters long", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, “”", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_()
        {
#line 10
 this.AcceptanceCriteriaScenarios("“”", "False", "False", "Input string was not 7-characters long", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, 12", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_12()
        {
#line 10
 this.AcceptanceCriteriaScenarios("12", "False", "False", "Input string was not 7-characters long", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, 123456789", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_123456789()
        {
#line 10
 this.AcceptanceCriteriaScenarios("123456789", "False", "False", "Input string was not 7-characters long", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, 0709954", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_0709954()
        {
#line 10
 this.AcceptanceCriteriaScenarios("0709954", "True", "False", "No message", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, B0YBKJ7", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_B0YBKJ7()
        {
#line 10
 this.AcceptanceCriteriaScenarios("B0YBKJ7", "True", "False", "No message", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, 9123458", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_9123458()
        {
#line 10
 this.AcceptanceCriteriaScenarios("9123458", "True", "True", "No message", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acceptance Criteria Scenarios, 9ABCDE1", new string[] {
                "UnitTest"}, SourceLine=18)]
        public virtual void AcceptanceCriteriaScenarios_9ABCDE1()
        {
#line 10
 this.AcceptanceCriteriaScenarios("9ABCDE1", "True", "True", "No message", ((string[])(null)));
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
