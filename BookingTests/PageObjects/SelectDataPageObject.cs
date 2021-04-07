using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class SelectDataPageObject
    {
        private IWebDriver _driver;

        private readonly By _selectTenAprilButton = By.XPath("//td[@data-date='2021-04-10']");
        private readonly By _selectTwelveAprilButton = By.XPath("//td[@data-date='2021-04-12']");

        public SelectDataPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public SelectGuestsPageObject SelectData()
        {
            _driver.FindElement(_selectTenAprilButton).Click();
            _driver.FindElement(_selectTwelveAprilButton).Click();
            return new SelectGuestsPageObject(_driver);
        }
    }
}
