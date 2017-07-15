using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace SpecFlow_NewProject.Step_Definitions
{
    [Binding]

    public class LoginQASteps
    {
        public IWebDriver driver;

        [Given(@"I have entered url into the \""(.*)""")]
        public void GivenIHaveEnteredIntoTheCalculator(string Browser)
        {
            driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["url"];
            driver.Manage().Window.Maximize();
        }

        [Given(@"I have entered \""(.*)"" as well as \""(.*)""")]
        public void GivenIHaveEnteredAsWellAs(string username, string passname)
        {
            driver.FindElement(By.XPath(ConfigurationManager.AppSettings["uname_xpath"])).SendKeys(username);
            driver.FindElement(By.XPath(ConfigurationManager.AppSettings["pname_xpath"])).SendKeys(passname);
        }
        
        [When(@"I press loginBtn_xpath")]
        public void WhenIPressAdd()
        {
            driver.FindElement(By.XPath(ConfigurationManager.AppSettings["loginBtn_xpath"])).Click();
        }

        [Then(@"the result should be \""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string status)
        {
            
        }

    }
}
