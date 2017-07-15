using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Specflow_dummy
{
    [Binding]
    public class HotelappTestSteps
    {
        [Given(@"I go to ""(.*)"" on Chrome")]
        public void GivenIGoToOnChrome(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter username as ""(.*)""")]
        public void GivenIEnterUsernameAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter password as ""(.*)""")]
        public void GivenIEnterPasswordAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press on Login button")]
        public void WhenIPressOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see login success message")]
        public void ThenISeeLoginSuccessMessage()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
