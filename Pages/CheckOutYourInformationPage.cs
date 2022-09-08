using OpenQA.Selenium;
using Xunit;

namespace TestDemoBDD.Pages
{
    public class CheckOutYourInformationPage
    {
        private IWebDriver driver;
        private IWebElement firstName, lastName, postalCode, continueButton;
        public CheckOutYourInformationPage(IWebDriver _driver)
        {
            driver = _driver;
            firstName = driver.FindElement(By.Id("first-name"));
            lastName = driver.FindElement(By.Id("last-name"));
            postalCode = driver.FindElement(By.Id("postal-code"));
            continueButton = driver.FindElement(By.Id("continue"));
        }

        public void setFirstName(string firstNameText)
        {
            firstName.SendKeys(firstNameText);
        }

        public void setLastName(string lastNameText)
        {
            lastName.SendKeys(lastNameText);
        }

        public void setPostalCode(string postalCodeText)
        {
            postalCode.SendKeys(postalCodeText);
        }

        public void clickOnContinueButton()
        {
            continueButton.Click();
        }

    }
}
