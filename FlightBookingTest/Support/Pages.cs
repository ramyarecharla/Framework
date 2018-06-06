using FlightBookingTest.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingTest.Support
{
    public class Pages : Base
    {
        public static FlightBookingPage FlightBookingPage
        {
            get
            {
                var flightBookingPage = new FlightBookingPage();
                return flightBookingPage;
            }
        }
    }
}
