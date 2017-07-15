using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace myspecflow
{
    [Binding]
    public class Class1
    {
        [Given(@"I go to ""(.*)"" on ""(.*)""")]
        public void GivenIGoToOn(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter ""(.*)"" as ""(.*)""")]
        public void GivenIEnterAs(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press on ""(.*)""")]
        public void WhenIPressOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"login should be ""(.*)""")]
        public void ThenLoginShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
