using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System.Configuration;


namespace newsepcflow
{
   public class WebConnectors
    {
        public IWebDriver driver;
        public IWebDriver firefox = null;
        public IWebDriver ie = null;
        public IWebDriver chrome = null;
        public static WebConnectors w = null;

        private WebConnectors()
        {
            //Console.WriteLine(ConfigurationManager.AppSettings["url"]);
        }
        public void openBrowser(string browser)
        {
            if (browser.Equals("Chrome") && chrome == null)
            {
                driver = new ChromeDriver();
                chrome = driver;
            }
            else if (browser.Equals("Chrome") && chrome != null)
            {
                driver = chrome;
            }
            else if (browser.Equals("Firefox") && firefox == null)
            {
                driver = new FirefoxDriver();
                firefox = driver;
            }
            else if (browser.Equals("Firefox") && firefox != null)
            {
                driver = firefox;
            }
            else if (browser.Equals("Iexplore") && ie == null)
            {
                driver = new InternetExplorerDriver();
                ie = driver;
            }
            else if (browser.Equals("Iexplore") && ie != null)
            {
                driver = ie;
            }
        }

        public void navigateURL(string url)
        {
            driver.Url = ConfigurationManager.AppSettings["url"];
            driver.Manage().Window.Maximize();
        }

        public void typeTxt(string objectname, string txt)
        {
            driver.FindElement(By.XPath(ConfigurationManager.AppSettings[objectname])).SendKeys(txt);
        }

        public void clickBtn(string objectname)
        {
            driver.FindElement(By.XPath(ConfigurationManager.AppSettings[objectname])).Click();
        }

        public void clickLink(string objectname)
        {
            driver.FindElement(By.LinkText(objectname)).Click();
        }

        public void verifyLink(string objectname)
        {
            IWebElement ele_present = driver.FindElement(By.LinkText(objectname));
            Console.WriteLine(ele_present.Displayed.GetType());
        }

        public void verifyTitle()
        {
            Console.WriteLine("Window Title:= " + driver.Title.GetType());

        }


        public static WebConnectors getInstance()
        {
            if (w == null)
                w = new WebConnectors();
            return w;

        }
    }
}
