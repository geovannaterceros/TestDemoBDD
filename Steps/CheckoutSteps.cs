using System;
using TechTalk.SpecFlow;
using TestDemoBDD.Pages;
using TestDemoBDD.Utilities;

namespace TestDemoBDD.Steps
{
    [Binding]
    public class CheckoutSteps
    {

        CheckOutYourInformationPage checkoutYour = new CheckOutYourInformationPage(DriveManager.getInstance().getDriver());
       
        [When(@"I fill the customer data with")]
        public void WhenIFillTheCustomerDataWith(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            var last = dictionary["lastName"];
            var first = dictionary["firstName"];
            var codigo = dictionary["codigoPostal"];
            checkoutYour.setFirstName(first);
            checkoutYour.setLastName(last);
            checkoutYour.setPostalCode(codigo);
        }
        
        [When(@"I click on continue button")]
        public void WhenIClickOnContinueButton()
        {
            checkoutYour.clickOnContinueButton();
        }
        
        [When(@"I click on finish button")]
        public void WhenIClickOnFinishButton()
        {
            CheckOutOverviewPage checkoutOverview = new CheckOutOverviewPage(DriveManager.getInstance().getDriver());
            checkoutOverview.ClickOnFinish();
        }
        
        [Then(@"I should see a message that says ""(.*)""")]
        public void ThenIShouldSeeAMessageThatSays(string messageText)
        {
            CheckoutCompletePage checkoutComplete = new CheckoutCompletePage(DriveManager.getInstance().getDriver());
            checkoutComplete.verifyOrderMessage(messageText);
        }
    }
}
