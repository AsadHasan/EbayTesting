using static AutoTesting.steps.helpers.StepsHelper;
using TechTalk.SpecFlow;

namespace AutoTesting.steps.topCategories
{
    [Binding]
    class Givens
    {
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            goToHomepage();
        }

    }
}
