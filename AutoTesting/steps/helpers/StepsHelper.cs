using OpenQA.Selenium;
using System.Configuration;
using static AutoTesting.steps.helpers.WebdriverFactory;

namespace AutoTesting.steps.helpers
{
    class StepsHelper
    {
        private IWebDriver webDriver;

        public static void goToHomepage()
        {
            var url = ConfigurationManager.AppSettings["HomeURL"];
            getDriver().Navigate().GoToUrl(url);
        }
    }
}
