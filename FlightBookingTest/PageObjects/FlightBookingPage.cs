using FlightBookingTest.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FlightBookingTest.PageObjects
{
    public class FlightBookingPage : Utilities
    {
        public readonly string _siteUrl = ScenarioContext.Current.Get<string>("currentwebsite");

        public FlightBookingPage()
        {
            if (!Driver.Url.Contains(_siteUrl))
                NavigateToUrl(_siteUrl);
        }

        


        private void NavigateToUrl(string siteUrl)
        {
            Driver.Navigate().GoToUrl(siteUrl);
            WaitForPageToLoad();
        }

        public void StartBooking()
        {

        }

    }
}
