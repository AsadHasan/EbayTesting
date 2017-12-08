using TechTalk.SpecFlow;

namespace AutoTesting.steps.topCategories
{
    [Binding]
    class Whens
    {
        [When(@"I hover over (.*)")]
        public void WhenIHoverOverMenuOption(string menuOption)
        {
        }

    }
}
