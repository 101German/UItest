using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class SelectLangMenuPageObject
    {
        private IWebDriver _driver;

        private readonly By _selectEnButton = By.XPath("//a[@hreflang= 'en-us']");

        public SelectLangMenuPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public MainMenuPageObject SelectEn()
        {
            WaitUntil.WaitElement(_driver, _selectEnButton);
            _driver.FindElement(_selectEnButton).Click();
            return new MainMenuPageObject(_driver);
        }
    }
}
