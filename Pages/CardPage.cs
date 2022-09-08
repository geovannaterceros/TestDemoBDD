using OpenQA.Selenium;
using System;
using Xunit;

namespace TestDemoBDD.Pages
{
    public class CardPage
    {
        private IWebDriver driver;
        private IWebElement itemAdd;
        private IWebElement priceAdd;
        private IWebElement checkout;

        public CardPage(IWebDriver _driver)
        {
            driver = _driver;
            itemAdd = driver.FindElement(By.Id("item_4_title_link"));
            priceAdd = driver.FindElement(By.ClassName("inventory_item_price"));
            checkout = driver.FindElement(By.Id("checkout"));
        }

        public void verifyOnCardSauceLabsBackPack(string item, decimal price)
        {
            Assert.Equal(item, itemAdd.Text);
            Assert.Equal(price, Convert.ToDecimal(priceAdd.Text.Remove(0,1)));
        }

        public void clickOnButtonCheckout()
        {
            checkout.Click();
        }
    }
}
