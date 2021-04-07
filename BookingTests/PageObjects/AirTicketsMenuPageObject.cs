using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    public class AirTicketsMenuPageObject
    {
        private IWebDriver _driver;

      
        public AirTicketsMenuPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
