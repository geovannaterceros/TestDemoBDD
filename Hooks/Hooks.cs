
using TechTalk.SpecFlow;
using TestDemoBDD.Utilities;


namespace TestDemoBDD.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            DriveManager.getInstance().getDriver().Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriveManager.getInstance().getDriver().Dispose();
        }
    }
}
