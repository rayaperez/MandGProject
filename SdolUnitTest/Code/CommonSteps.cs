using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SdolUnitTest.Code
{
    [Binding]
    public class CommonSteps 
    { 

        [Given(@"I am on SEDOL webpage")]
        public void GivenIAmOnSEDOLWebpage()
        {
             BaseSteps.webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["sedolWebApp"]);
        }

        [Given(@"page is fully loaded")]
        public void GivenPageIsFullyLoaded()
        {
            Assert.IsTrue(BaseSteps.webDriver.FindElement(By.Id("inputBox")).Enabled);
            BaseSteps.log.Info("Sedol Web Application page is fully loaded");
        }
    }
}
