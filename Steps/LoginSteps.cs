using TechTalk.SpecFlow;
using TestDemoBDD.Pages;
using TestDemoBDD.Utilities;

namespace TestDemoBDD.Steps
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage = new LoginPage(DriveManager.getInstance().getDriver());
     
        [Given(@"I set username with ""(.*)""")]
        public void GivenISetUsernameWith(string userName)
        {
            loginPage.setUserNameTextBox(userName);
        }
        
        [Given(@"I set password with ""(.*)""")]
        public void GivenISetPasswordWith(string password)
        {
            loginPage.setPasswordTextBox(password);
        }
        
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.clickOnLoginButton();
        }
        
        [Then(@"I verify that a error message that says ""(.*)""")]
        public void VerifyErrorMessageText(string errorText)
        {
            loginPage.verifiyErrorMessageText(errorText);
        }
    }
}
