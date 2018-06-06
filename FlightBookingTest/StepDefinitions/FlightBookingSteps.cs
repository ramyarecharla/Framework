using System;
using TechTalk.SpecFlow;
using FlightBookingTest.Support;

namespace FlightBookingTest.StepDefinitions
{
    [Binding]
    public class FlightBookingSteps : Utilities
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            FlightBookingPage.StartBooking();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }
    }
}
