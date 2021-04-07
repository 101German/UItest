using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class HotelPageObject
    {
        private IWebDriver _driver;


        private readonly By _dataOfStay = By.XPath("//time[@datetime='сб, 10 апр. 2021']");
        private readonly By _departureData = By.XPath("//time[@datetime='пн, 12 апр. 2021']");
        private readonly By _countOfGuests = By.XPath("//a[@id='av-summary-occupancy']");

        public HotelPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetGuestsCounts()
        {
            WaitUntil.WaitElement(_driver, _countOfGuests);
            return _driver.FindElement(_countOfGuests).Text;
        }
        public string GetDateOfStay()
        {
            WaitUntil.WaitElement(_driver, _dataOfStay);
            return _driver.FindElement(_dataOfStay).Text;
        }

        
        public string GetDateOfDeparture()
        {
            WaitUntil.WaitElement(_driver, _departureData);
            return _driver.FindElement(_departureData).Text;
        }


    }
}
