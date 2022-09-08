

using OpenQA.Selenium;
using Xunit;

namespace TestDemoBDD.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        private IWebElement errorMessage;
        private IWebElement userNameTextBox;
        private IWebElement passwordTextBox;
        private IWebElement buttonLogin;

        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
            userNameTextBox = driver.FindElement(By.Id("user-name"));
            passwordTextBox = driver.FindElement(By.Id("password"));
            buttonLogin = driver.FindElement(By.Id("login-button"));            
        }

        public void setUserNameTextBox(string userName)
        {
            userNameTextBox.SendKeys(userName);
        }

        public void setPasswordTextBox(string password)
        {
            passwordTextBox.SendKeys(password);
        }

        public void clickOnLoginButton()
        {
            buttonLogin.Click();
        }

        public void verifiyErrorMessageText(string errorText)
        {
            errorMessage = driver.FindElement(By.XPath("//h3[@data-test]"));
            Assert.Equal(errorText, errorMessage.Text);
        }
    }
}
