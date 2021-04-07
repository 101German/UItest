using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class SelectGuestsPageObject
    {
        private IWebDriver _driver;

        private readonly By _selectGuestsCountButton = By.XPath("//span[@class='xp__guests__count']");
        private readonly By _addChildrenButton = By.XPath("//button[@aria-label='Детей: увеличить количество']");
        public SelectGuestsPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public MainMenuPageObject SelectGuestsCount()
        {
            _driver.FindElement(_selectGuestsCountButton).Click();
            _driver.FindElement(_addChildrenButton).Click();
            return new MainMenuPageObject(_driver);
        }
    }
}
