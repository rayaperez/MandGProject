using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SdolUnitTest.Code
{
    [Binding]
    public class ScenariosSteps 
    { 
        [Given(@"I enter following sedol number (.*)")]
        public void GivenIEnterFollowingSedolNumber(string sedolNumber)
        {
            BaseSteps.webDriver.FindElement(By.Id("inputBox")).SendKeys(sedolNumber);
        }
        
        [Given(@"Is Valid Sedol status is  (.*)")]
        public void GivenIsValidSedolStatusIsFollowing(string status)
        {
            ValidateStatus(status);
            if(status.Equals("True"))
            {
                BaseSteps.webDriver.FindElement(By.XPath("//*[@id='div1']/p[1]/input")).Click();
            } 
        }
        
        [Given(@"Is User Defined status is  (.*)")]
        public void GivenIsUserDefinedStatusIsFollowing(string status)
        {
            ValidateStatus(status);
            if (status.Equals("True"))
            {
                BaseSteps.webDriver.FindElement(By.XPath("//*[@id='div1']/p[2]/input")).Click();
            }
        }
        
        [When(@"I press Submit")]
        public void WhenIPressSubmit()
        {
            BaseSteps.webDriver.FindElement(By.Id("submitSedol")).Click();
        }

        [Then(@"I receive the message (.*)")]
        public void ThenIReceiveTheMessage(string expectedMessage)
        {
            char[] charsToTrim = { '.', ' ' };
            string adjustedExpectedMessage = expectedMessage.Trim(charsToTrim);
            if (adjustedExpectedMessage.Equals("No message"))
            {
                try
                {
                    Assert.IsTrue(!BaseSteps.webDriver.FindElement(By.ClassName("loader")).Displayed);
                }
                catch (NoSuchElementException nsne)
                {
                    BaseSteps.log.Error(string.Format("NoSuchElementException has been throwns : {0}",nsne.ToString()));
                }
            }
            else
            {
                IWebElement element = BaseSteps.webDriver.FindElement(By.ClassName("loader"));
                string messageFromUI = element.Text;
                Assert.AreEqual(messageFromUI.Trim(charsToTrim), adjustedExpectedMessage.Trim(charsToTrim));
            }
           
        }


        private void ValidateStatus(string status)
        {
            int length = status.Length;
            if(length<=0)
            {
                BaseSteps.log.Error("Status is an empty");
                Assert.IsFalse(true);
            }
            else if (!status.Equals("True") && !status.Equals("False"))
            {
                BaseSteps.log.Error("Status code is different from True and False");
                Assert.IsFalse(true);
            } 
        }           
 }
}
