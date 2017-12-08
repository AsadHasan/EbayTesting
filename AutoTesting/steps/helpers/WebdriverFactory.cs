using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace AutoTesting.steps.helpers
{
    class WebdriverFactory
    {
        private static IWebDriver webDriver;

        public static IWebDriver getDriver()
        {
            if (webDriver == null)
            {
                var browser = ConfigurationManager.AppSettings["browser1"];
                switch (browser)
                {
                    case "chrome":
                        var options = new ChromeOptions();
                        options.AddArguments("--headless");
                        options.AddArguments("--diable-gpu");
                        webDriver = new ChromeDriver(options);
                        break;
                    case "internetexplorer":
                        webDriver = new InternetExplorerDriver();
                        break;
                    case "edge":
                        webDriver = new EdgeDriver();
                        break;
                }
            }
            return webDriver;
        }
    }
}
