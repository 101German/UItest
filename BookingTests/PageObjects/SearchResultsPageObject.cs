using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class SearchResultsPageObject
    {
        private IWebDriver _driver;

        private readonly By _firstHotelButton = By.XPath("//a[@class='js-sr-hotel-link hotel_name_link url']");
        private readonly By _townName = By.XPath("//a[@class='bui-link']");
        

        public SearchResultsPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public HotelPageObject SelectHotel()
        {
            WaitUntil.WaitElement(_driver, _firstHotelButton);
            _driver.FindElement(_firstHotelButton).Click();
           _driver.SwitchTo().Window(_driver.WindowHandles.Last());

            return new HotelPageObject(_driver);
        }
        public string GetTownName()
        {

            WaitUntil.WaitElement(_driver, _townName);
            return _driver.FindElement(_townName).Text;


        }
        
    }
}
