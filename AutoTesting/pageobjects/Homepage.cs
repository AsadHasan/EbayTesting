using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoTesting.pageobjects
{
    class Homepage
    {
        public const string URL = "https://www.ebay.co.uk/";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "s0-container")]
        private IList<IWebElement> menuOptions;

        public Homepage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }
    }
}
