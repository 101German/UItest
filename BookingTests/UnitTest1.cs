using BookingTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace BookingTests
{
    public class Tests
    {
        private IWebDriver _driver;

       
        [SetUp]
        public void Setup()
        {
            _driver = new OpenQA.Selenium.Opera.OperaDriver();
            _driver.Navigate().GoToUrl(UrlForTests.BookingUrl);
            _driver.Manage().Window.Maximize();
           
            WaitUntil.ShouldLocate(_driver,UrlForTests.BookingUrl);
        }

        [Test]
        public void ChangeCurrencyAndLang()
        {
            var mainMenu = new MainMenuPageObject(_driver);
            mainMenu
                .SelectRateButtonClick()
                .SelectUsd()
                .SelectLangButtonClick()
                .SelectEn();

            

        }
        [Test]
        public void AirTicketsPageTest()
        {

            var mainMenu = new MainMenuPageObject(_driver);
            mainMenu.AirTicketsButtonClick();
            string CurrentUrl = _driver.Url.Remove(25);
            Assert.AreEqual(UrlForTests.AirTicketsPageUrl, CurrentUrl);

        }
        [Test]
        public void LoginedTest()
        {

            var mainMenu = new MainMenuPageObject(_driver);
            mainMenu
                .SignInButtonClick()
                .InputLogin()
                .InputLoginButtonClick()
                .InputPassword()
                .InputPasswordButtonClick();
            string actualLogin = mainMenu.GetActualLogin();
            Assert.AreEqual("Ваш аккаунт", actualLogin);

        }

        [Test]
        public void FilterTest()
        {
            var mainMenu = new MainMenuPageObject(_driver);
            mainMenu
                .InputTown()
                .SelectData()
                .SelectGuestsCount()
                .ApllyFilters();

            var serchResultPage = new SearchResultsPageObject(_driver);
            string townName = serchResultPage.GetTownName();
            
            var hotelPage = serchResultPage.SelectHotel();

            string guestsCount = hotelPage.GetGuestsCounts();
            string dateOfStay = hotelPage.GetDateOfStay();
            string dateOfDeparture = hotelPage.GetDateOfDeparture();

            Assert.AreEqual(true, townName.Contains(ExpectedFiltersData.townName), "Wrong city name");
            Assert.AreEqual(true,guestsCount.Contains(ExpectedFiltersData.countOfGuests),"Wrong counts of Guests");
            Assert.AreEqual(true, dateOfStay.Contains(ExpectedFiltersData.dateOfStay), "Wrong date of stay");
            Assert.AreEqual(true, dateOfDeparture.Contains(ExpectedFiltersData.dateOfDeparture), "Wrong date of departure");
        }


        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}