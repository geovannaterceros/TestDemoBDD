using OpenQA.Selenium;
using Xunit;

namespace TestDemoBDD.Pages
{
    public class CheckOutOverviewPage
    {
        private IWebDriver driver;
        private IWebElement finishButton;

        public CheckOutOverviewPage(IWebDriver _driver)
        {
            driver = _driver;
            finishButton = driver.FindElement(By.Id("finish"));
        }

        public void ClickOnFinish()
        {
            finishButton.Click();
        }
    }

}
