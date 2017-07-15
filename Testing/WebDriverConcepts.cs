using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;


namespace isMethods
{
    public class WebDriverConcepts
    {
        public IWebDriver driver;
        public void isEnabledMethod()
        {
            driver = new ChromeDriver();
            driver.Url = "http://adactin.com/HotelApp/";
            driver.Manage().Window.Maximize();
            IWebElement ele=driver.FindElement(By.Id("username"));
            Console.WriteLine("isEnabled Button:= "+ele.Enabled);
            ele.SendKeys("seleniumtesting");
        }

        public void isDisplayMethod()
        {
            driver = new ChromeDriver();
            driver.Url = "http://adactin.com/HotelApp/";
            driver.Manage().Window.Maximize();
            IWebElement ele = driver.FindElement(By.Id("username"));
            Console.WriteLine("isDisplay Button:= " + ele.Displayed);
            ele.SendKeys("seleniumtesting");
        }

        public void isSelectMethod()
        {
            driver = new ChromeDriver();
            driver.Url = "http://adactin.com/HotelApp/Register.php";
            driver.Manage().Window.Maximize();
            IWebElement ele = driver.FindElement(By.Id("tnc_box"));
            Console.WriteLine("isSelect Before Click:= " + ele.Selected);
            ele.Click();
            Console.WriteLine("isSelect After Click:= " + ele.Selected);
        }
        
    }
}


namespace getAttribute
{
    public class WebDriverConcepts
    {
        public IWebDriver driver;
        public void getAttribute_value()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.w3schools.com/jquery/tryit.asp?filename=tryjquery_html_val_set";
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeResult")));
            IWebElement ele = driver.FindElement(By.Name("user"));
            ele.SendKeys("test box");
            Console.WriteLine("Entered Value:= "+ele.GetAttribute("value"));
        }
    }
}

namespace switchTo
{
    public class WebDriverConcepts
    {
        public IWebDriver driver;
        public void iframe_switchTo()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.w3schools.com/jquery/tryit.asp?filename=tryjquery_html_val_set";
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeResult")));
            IWebElement ele=driver.FindElement(By.Name("user"));
            ele.SendKeys("test box");
        }


        public void iframe_switchTo_frameName()
        {
            driver = new InternetExplorerDriver();
            driver.Url = "https://www.w3schools.com/jsref/tryit.asp?filename=tryjsref_onclick";
           // driver.Manage().Window.Maximize();
            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeResult")));
            driver.FindElement(By.XPath("//button[contains(text(),'Click me')]")).Click();
        }

        public void popupWindow_switchTo()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.w3schools.com/tags/tryit.asp?filename=tryhtml_link_target";
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeResult")));
            Console.WriteLine("Title Before switch window:= " + driver.Title);
            driver.FindElement(By.LinkText("Visit W3Schools.com!")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Console.WriteLine("Title After switch window:= " + driver.Title);
        }

        public void alert_switchTo()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.w3schools.com/js/tryit.asp?filename=tryjs_confirm";
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeResult")));
            IWebElement ele = driver.FindElement(By.XPath("//button[contains(text(),'Try it')]"));
            ele.Click();
            Console.WriteLine("Alert Message:= "+driver.SwitchTo().Alert().Text);
            driver.SwitchTo().Alert().Accept();
        }
    }
}

namespace browserTypes
{
    public class WebDriverConcepts
    {
        public IWebDriver driver;
        public void openChrome_Browser()
        {
            driver = new ChromeDriver();
            driver.Url = "http://adactin.com/HotelApp/";
            driver.Manage().Window.Maximize();
        }

        public void openFirefox_Browser()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://adactin.com/HotelApp/";
            driver.Manage().Window.Maximize();
        }

        public void openIE_Browser()
        {
            driver = new InternetExplorerDriver();
            driver.Url = "http://adactin.com/HotelApp/";
            driver.Manage().Window.Maximize();
        }
    }
}


namespace dropDownList
{
    public class WebDriverConcepts
    {
        public IWebDriver driver;
        public void dropDownList()
        {
            driver = new ChromeDriver();
            driver.Url = "http://adactin.com/HotelApp/index.php";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("username")).SendKeys("seleniumtesting");
            driver.FindElement(By.Id("password")).SendKeys("password1");
            Thread.Sleep(6000);
            driver.FindElement(By.Id("login")).Click();
            Thread.Sleep(3000);

            IWebElement ele = driver.FindElement(By.XPath("//*[@id='location']"));
            IList<IWebElement> list = ele.FindElements(By.TagName("option"));
            for(int i=0;i< list.Count(); i++)
            {
                Console.WriteLine("DropDown Values:= "+list[i].Text);

            }
        }
    }
}

namespace popupWindows_Handling
{
    public class WebDriverConcepts
    {
        public IWebDriver driver;
        public void popupWindow_switchTo()
        {
            driver = new InternetExplorerDriver();
            driver.Url = "http://www.cricbuzz.com/cricket-stats/icc-rankings";
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            IWebElement ele=driver.FindElement(By.XPath("/html"));
            ele.SendKeys(Keys.PageDown);
            ele.SendKeys(Keys.PageDown);
            Console.WriteLine("Title Before switch window:= " + driver.Title);
            driver.FindElement(By.XPath("//*[@id='FooterWraper']/div/div/div[3]/ul/li[2]/a/span[2]")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Console.WriteLine("Title After switch window:= " + driver.Title);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("About")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Console.WriteLine("Title After switch window:= " + driver.Title);
            driver.Manage().Window.Maximize();
            driver.Close();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles.First());
            
            Console.WriteLine("Title of First Window:= " + driver.Title);
            driver.FindElement(By.XPath("//*[@id='FooterWraper']/div/div/div[2]/ul/li[4]/a/span[2]")).Click();
            

        }

        public void countWindows_switchTo()
        {
            driver = new InternetExplorerDriver();
            driver.Url = "http://www.cricbuzz.com/cricket-stats/icc-rankings";
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            IWebElement ele = driver.FindElement(By.XPath("/html"));
            ele.SendKeys(Keys.PageDown);
            ele.SendKeys(Keys.PageDown);
            Console.WriteLine("Title Before switch window:= " + driver.Title);
            driver.FindElement(By.XPath("//*[@id='FooterWraper']/div/div/div[3]/ul/li[2]/a/span[2]")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Console.WriteLine("Title After switch window:= " + driver.Title);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("About")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Console.WriteLine("Title After switch window:= " + driver.Title);
            driver.Manage().Window.Maximize();

            foreach(string handles in driver.WindowHandles)
            {
                Console.WriteLine("Window IDs:= " + handles);
            }

        }

        public void countANDSwitch_switchTo()
        {
            driver = new InternetExplorerDriver();
            driver.Url = "http://www.cricbuzz.com/cricket-stats/icc-rankings";
            driver.Manage().Window.Maximize();
            string parentWindow = driver.CurrentWindowHandle;
            Thread.Sleep(4000);
            IWebElement ele = driver.FindElement(By.XPath("/html"));
            ele.SendKeys(Keys.PageDown);
            ele.SendKeys(Keys.PageDown);
            Console.WriteLine("Title Before switch window:= " + driver.Title);
            driver.FindElement(By.XPath("//*[@id='FooterWraper']/div/div/div[3]/ul/li[2]/a/span[2]")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Console.WriteLine("Title After switch window:= " + driver.Title);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("About")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Console.WriteLine("Title After switch window:= " + driver.Title);
            driver.Manage().Window.Maximize();

            

            foreach (string handles in driver.WindowHandles)
            {
                
                if (!handles.Equals(parentWindow))
                {
                    driver.SwitchTo().Window(handles);
                }

            }
        }

    }
}

