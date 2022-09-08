using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TestDemoBDD.Pages;
using TestDemoBDD.Utilities;

namespace TestDemoBDD.Steps
{
    [Binding]
    public class HomeSteps
    {
        private HomePage homePage = new HomePage(DriveManager.getInstance().getDriver());

        [When(@"I am in the home page")]
        public void WhenIAmInTheHomePage()
        {
            homePage.verifiyHomePageIsDisplayed();
        }
        
        [Then(@"I verify that (.*) is displayed")]
        public void ThenIVerifyThatSauceLabsBackpackIsDisplayed(string item)
        {
            homePage.verifyItemHomePage(item);
        }

        [When(@"I add Sauce Labs Backpack product to the cart")]
        public void WhenIAddProductInTheCart()
        {
            homePage.clickOnAddSauceLabsBackPack();
        }

        [When(@"I click on the shopping card")]
        public void WhenIClickOnTheShoppingCard()
        {
            homePage.clickOnIconCard();
        }

    }
}
