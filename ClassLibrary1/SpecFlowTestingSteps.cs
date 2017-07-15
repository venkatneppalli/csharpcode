using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class SpecFlowTestingSteps
    {
        WebConnector web = WebConnector.getInstance();

        [Given(@"I go to \""(.*)"" on \""(.*)""")]
        public void GivenIGoToOn(string url, string browser)
        {
            web.openBrowser(browser);
            web.navigateURL(url);
        }
        
        [Given(@"I entered \""(.*)"" as \""(.*)""")]
        public void GivenIEnteredAs(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press \""(.*)""")]
        public void WhenIPress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should \""(.*)""")]
        public void ThenTheResultShould(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
