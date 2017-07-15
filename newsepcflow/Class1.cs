using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace newsepcflow
{
    [Binding]
    public class Class1
    {
        WebConnectors web = WebConnectors.getInstance();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            web.openBrowser("chrome");
            web.navigateURL("url");
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }

    }
}
