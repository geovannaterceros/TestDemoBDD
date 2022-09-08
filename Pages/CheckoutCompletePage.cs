using OpenQA.Selenium;
using Xunit;

namespace TestDemoBDD.Pages
{
    public class CheckoutCompletePage
    {
        private IWebDriver driver;
        private IWebElement thanksOrderMesage;

        public CheckoutCompletePage(IWebDriver _driver)
        {
            driver = _driver;
            thanksOrderMesage = driver.FindElement(By.ClassName("complete-header"));
        }

        public void verifyOrderMessage(string messageText) 
        {
            Assert.Equal(messageText, thanksOrderMesage.Text);
        }
    }
}
