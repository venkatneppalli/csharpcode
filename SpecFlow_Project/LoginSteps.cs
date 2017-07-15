using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Threading;

namespace SpecFlow_Project
{
    [Binding]
    public class LoginSteps
    {
        WebConnector web = WebConnector.getInstance();


        [Given(@"I go to \""(.*)"" on \""(.*)""")]
        public void GivenIGoToHttpAdactin_ComHotelAppOnChrome(string url,string browser)
        {
            web.openBrowser(browser);
            web.navigateURL(url);
           

        }

            [Given(@"I enter \""(.*)"" as \""(.*)""")]
            public void GivenIEnterUsernameAsSeleniumtesting(string objectname,string uidpwd)
            {
            web.typeTxt(objectname, uidpwd);
            Thread.Sleep(3000);
            }
        
            [When(@"I press on \""(.*)""")]
            public void WhenIPressOnLoginbutton(string objname)
            {
            web.clickBtn(objname);
            }

            [Then(@"login should be \""(.*)""")]
            public void ThenLoginShouldBeSuccess(string objectname)
            {
            Thread.Sleep(3000);
            web.verifyLink("Logout");
            }
        }
    }

