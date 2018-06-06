using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FlightBookingTest.Support
{
    [Binding]
    public class Events
    {
        public static RemoteWebDriver Driver = null;

        [BeforeScenario("url")]
        public void FlightBookingUrl()
        {
            ScenarioContext.Current.Add("currentwebsite", ConfigurationManager.AppSettings["url"]);
        }

        [BeforeScenario("initialize")]
        public void InitialiazeDriver()
        {
            Driver = Driver ?? StartDriver(ConfigurationManager.AppSettings["browser"]);
            ScenarioContext.Current.Set(Driver, "currentDriver");
        }

        [AfterScenario("initialize")]
        public void AfterScenario()
        {
            if(ScenarioContext.Current.TestError!= null)
            {
                ScenarioContext.Current.Get<RemoteWebDriver>("currentDriver").Quit();
                Driver = null;
            }
            ScenarioContext.Current.Clear();
        }

        [AfterScenario("after")]
        public void QuitDriverAfterScenario()
        {
            Driver.Quit();
            Driver = null;
        }

        [AfterTestRun]
        public static void StopSeleniumTestsAfterAllTests()
        {
            Driver?.Quit();
        }

        private static RemoteWebDriver StartDriver(string browser)
        {
            RemoteWebDriver driver;
            switch(browser)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                default: throw new ConfigurationErrorsException("Broswer app config was not set properly");
            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("about:blank");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}
