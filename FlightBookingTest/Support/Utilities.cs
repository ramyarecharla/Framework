using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingTest.Support
{
    public class Utilities : Pages
    {
        public static IJavaScriptExecutor js;

        public bool IsElementPresent(IWebElement element,double waitTimeInSecond = 30)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            WebDriverWait wait = new WebDriverWait(Events.Driver, TimeSpan.FromSeconds(waitTimeInSecond));
            bool flag = true;
            try
            {
                wait.Until(x => element.Displayed);
            }
            catch(Exception)
            {
                flag = false;
            }
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return flag;
        }
    }
}
