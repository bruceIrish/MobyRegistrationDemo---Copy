﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.3.0
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MobyRegistrationDemo
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.3.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MobyMax Registration")]
    public partial class MobyMaxRegistrationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MTest.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MobyMax Registration", "Feature details", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("End to End registration")]
        [NUnit.Framework.CategoryAttribute("RegistrationTest_EndToEnd")]
        [NUnit.Framework.TestCaseAttribute("http://www.mobymax.com/", "IE", "John", "//*[@id=\"register-element-form\"]/div[1]/input", "Doe1", "//*[@id=\"register-element-form\"]/div[2]/input", "teacher", "//*[@id=\"register-element-form\"]/div[3]/div[1]/img", "15122", "//*[@id=\"register-element-form\"]/div[8]/input", "13560", "//*[@id=\"register-element-form\"]/div[9]/input[1]", "jdoe586@gmail.com", "//*[@id=\"register-element-form\"]/div[13]/input", "abc123", "//*[@id=\"register-element-form\"]/div[14]/div/input", "//*[@id=\"register-button\"]", "//*[@id=\"video-dialog\"]/div/div[2]", "//*[@id=\"welcome\"]", "http://www.mobymax.com/MM/MT/Welcome", null)]
        [NUnit.Framework.TestCaseAttribute("http://www.mobymax.com/", "Chrome", "John", "//*[@id=\"register-element-form\"]/div[1]/input", "Doe 2", "//*[@id=\"register-element-form\"]/div[2]/input", "teacher", "//*[@id=\"register-element-form\"]/div[3]/div[1]/img", "15122", "//*[@id=\"register-element-form\"]/div[8]/input", "13560", "//*[@id=\"register-element-form\"]/div[9]/input[1]", "jdoe70@gmail.com", "//*[@id=\"register-element-form\"]/div[13]/input", "jd12342", "//*[@id=\"register-element-form\"]/div[14]/div/input", "//*[@id=\"register-button\"]", "//*[@id=\"video-dialog\"]/div/div[1]", "//*[@id=\"welcome\"]", "http://www.mobymax.com/MM/MT/Welcome", null)]
        public virtual void EndToEndRegistration(
                    string uRL, 
                    string browser, 
                    string firstname, 
                    string firstnameField, 
                    string lastname, 
                    string lastnameField, 
                    string educator, 
                    string educatorCheckbox, 
                    string zipcode, 
                    string zipcodeField, 
                    string schoolId, 
                    string schoolField, 
                    string emailAddress, 
                    string emailField, 
                    string password, 
                    string passwordField, 
                    string registerXpath, 
                    string welcomeModal, 
                    string welcomeXpath, 
                    string welcomeURL, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegistrationTest_EndToEnd"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("End to End registration", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given(string.Format("I have navigated to URL {0} in browser {1}", uRL, browser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("I have entered firstname {0} into {1} and lastname {2} into {3}", firstname, firstnameField, lastname, lastnameField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And(string.Format("I have entered educator {0} into {1} of attribute \"data-checked\"", educator, educatorCheckbox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("I have entered zipcode {0} into {1} and school {2} into {3}", zipcode, zipcodeField, schoolId, schoolField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And(string.Format("I have entered email address {0} into {1} and password {2} into {3}", emailAddress, emailField, password, passwordField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And(string.Format("I press the Register button identified by {0}", registerXpath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then(string.Format("the result welcome page identified by dismissing the modal {0} contains title {1}" +
                        " matching {2} {3} and URL is {4}", welcomeModal, welcomeXpath, firstname, lastname, welcomeURL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Test If School dropdown list populates with appropriate schools upon entering cor" +
            "rect zip code")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("http://www.mobymax.com/", "IE", "15122", "//*[@id=\"register-element-form\"]/div[8]/input", "//*[@id=\"register-element-form\"]/div[9]/input[1]", "Calvary Baptist Preschool & Kind, Clara Barton El Sch, Early Childhood Education " +
            "Center,Homeville El Sch,New Emerson El Sch,New England El Sch,St Agnes School,Wa" +
            "lnut Grove Christian School,West Mifflin Area Hs,Wilson Christian Academy,School" +
            " not listed?", null)]
        [NUnit.Framework.TestCaseAttribute("http://www.mobymax.com/", "Chrome", "15122", "//*[@id=\"register-element-form\"]/div[8]/input", "//*[@id=\"register-element-form\"]/div[9]/input[1]", @"Calvary Baptist Preschool & Kind, Clara Barton El Sch, Early Childhood Education Center, Homeville El Sch, New Emerson El Sch, New England El Sch, St Agnes School, Walnut Grove Christian School, West Mifflin Area Hs, Wilson Christian Academy, School not listed?", null)]
        public virtual void TestIfSchoolDropdownListPopulatesWithAppropriateSchoolsUponEnteringCorrectZipCode(string uRL, string browsers, string zipcode, string zipcodeField, string schoolField, string listOfSchoolsPerZip, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test If School dropdown list populates with appropriate schools upon entering cor" +
                    "rect zip code", @__tags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given(string.Format("I have navigated to the URL {0} in browser <browser>", uRL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.When(string.Format("I enter the zip code {0} into {1} and click the school dropdown {2} containing {3" +
                        "}", zipcode, zipcodeField, schoolField, listOfSchoolsPerZip), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then(string.Format("School dropdown list should include the list of schools {0}", listOfSchoolsPerZip), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
