using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class AuthorizationPageObject
    {
        private IWebDriver _driver;

        private readonly By _loginInputField = By.XPath("//input[@type='email']");
        private readonly By _loginInputButton = By.XPath("//button[@class='bui-button bui-button--large bui-button--wide']");
        private readonly By _passwordInputField = By.XPath("//input[@type='password']");
        private readonly By _passwordInputButton = By.XPath("//button[@class='bui-button bui-button--large bui-button--wide']");

        public AuthorizationPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public AuthorizationPageObject InputLogin()
        {
            _driver.FindElement(_loginInputField).SendKeys(UserDataForTests.Login);
            return new AuthorizationPageObject(_driver);
        }
        public AuthorizationPageObject InputLoginButtonClick()
        {
            _driver.FindElement(_loginInputButton).Click();
            return new AuthorizationPageObject(_driver);
        }

        public AuthorizationPageObject InputPassword()
        {
            WaitUntil.WaitElement(_driver, _passwordInputField);
            _driver.FindElement(_passwordInputField).SendKeys(UserDataForTests.Password);
            return new AuthorizationPageObject(_driver);
        }
        public MainMenuPageObject InputPasswordButtonClick()
        {
            _driver.FindElement(_passwordInputButton).Click();
            return new MainMenuPageObject(_driver);
        }
    }
}
