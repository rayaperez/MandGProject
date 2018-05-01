using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SdolUnitTest.Code
{
    [Binding]
    public  class BaseSteps
    {
         public static IWebDriver webDriver;
         public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [BeforeScenario("UnitTest")]
        public void BeforeScenario()
        {
            webDriver = new ChromeDriver();
        }

        [AfterScenario("UnitTest")]
        public void AfterScenario()
        {
            webDriver.Quit();
        }
    }
}
