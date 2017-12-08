using TechTalk.SpecFlow;
using static AutoTesting.steps.helpers.WebdriverFactory;

namespace AutoTesting.steps
{
    [Binding]
    public sealed class Hooks
    {
        [AfterTestRun]
        public static void cleanup()
        {
            getDriver().Quit();
        }
    }
}
