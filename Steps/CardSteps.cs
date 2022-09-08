using System;
using TechTalk.SpecFlow;
using TestDemoBDD.Pages;
using TestDemoBDD.Utilities;

namespace TestDemoBDD.Steps
{
    [Binding]
    public class AsAUserIWantAddItemACardSteps
    {
        CardPage cardPage = new CardPage(DriveManager.getInstance().getDriver());
            
        [Then(@"I verify that (.*) and \$(.*) in the card")]
        public void ThenIVerifyThatSauceLabsBackpackAndInTheCard(string item, decimal price)
        {
            cardPage.verifyOnCardSauceLabsBackPack(item, price);
        }

        [When(@"I click on the checkout button")]
        public void WhenIClickOnTheCheckoutButton()
        {
            cardPage.clickOnButtonCheckout();
        }
    }
}
