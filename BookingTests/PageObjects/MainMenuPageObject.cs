using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class MainMenuPageObject
    {
        private IWebDriver _driver;

        private readonly By _rateButton = By.XPath("//button[@class='bui-button bui-button--light bui-button--large']");
        private readonly By _lanSelectButton = By.XPath("//button[@data-modal-id='language-selection']");
        private readonly By _airticketsButton = By.XPath("//a[@data-decider-header='flights']");
        private readonly By _signInButton = By.XPath("//span[contains(text(),'Войти в аккаунт')]");
        private readonly By _userLogin = By.XPath("//span[@id='profile-menu-trigger--title']");
        private readonly By _inputTownField = By.XPath("//input[@id='ss']");
        private readonly By _inputDataFieldButton = By.XPath("//div[@data-calendar2-title='Приезжаю']");
        private readonly By _apllyFilterButton = By.XPath("//button[@data-sb-id='main']");
        

        public MainMenuPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public SelectRateMenuPageObject SelectRateButtonClick()
        {
            _driver.FindElement(_rateButton).Click();
            return new SelectRateMenuPageObject(_driver);
        }
        public SelectLangMenuPageObject SelectLangButtonClick()
        {
            _driver.FindElement(_lanSelectButton).Click();
            return new SelectLangMenuPageObject(_driver);
        }

        public AirTicketsMenuPageObject AirTicketsButtonClick()
        {
            _driver.FindElement(_airticketsButton).Click();
            return new AirTicketsMenuPageObject(_driver);
        }

        public AuthorizationPageObject SignInButtonClick()
        {
            _driver.FindElement(_signInButton).Click();
            return new AuthorizationPageObject(_driver);
        }
        public string GetActualLogin()
        {
            WaitUntil.WaitElement(_driver, _userLogin);
            return _driver.FindElement(_userLogin).Text;
        }

        public SelectDataPageObject InputTown()
        {
            _driver.FindElement(_inputTownField).SendKeys("Минск");
            _driver.FindElement(_inputDataFieldButton).Click();
            return new SelectDataPageObject(_driver);
        }

        public SearchResultsPageObject ApllyFilters()
        {
            _driver.FindElement(_apllyFilterButton).Click();
            return new SearchResultsPageObject(_driver);
        }
    }
}
