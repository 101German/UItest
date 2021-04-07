using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class SelectRateMenuPageObject
    {
        private IWebDriver _driver;

        private readonly By _selectUsdButton = By.XPath("//a[@data-modal-header-async-url-param='changed_currency=1;selected_currency=USD;top_currency=1']");

        public SelectRateMenuPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public MainMenuPageObject SelectUsd()
        {
            WaitUntil.WaitElement(_driver, _selectUsdButton);
            _driver.FindElement(_selectUsdButton).Click();
            return new MainMenuPageObject(_driver);
        }
    }
}
