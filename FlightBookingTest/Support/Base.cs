using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingTest.Support
{
    public class Base
    {
        public static RemoteWebDriver Driver => ScenarioContext.Current.Get<RemoteWebDriver>("currentDriver");

        private WebDriverWait GenerateWebDriverWait(int seconds = 180)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
        }

        public void WaitForPageToLoad()
        {
            GenerateWebDriverWait().Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").ToString().Equals("complete"));
        }

        public void WaitForElement(IWebElement element)
        {
            GenerateWebDriverWait().Until(d => element.Displayed);
        }

    }
}
