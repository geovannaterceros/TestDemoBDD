using OpenQA.Selenium;
using Xunit;

namespace TestDemoBDD.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private IWebElement header;
        private IWebElement itemSauceLabsBackPack;
        private IWebElement addCardSauceBackPack;
        private IWebElement iconCard;

        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
            header = driver.FindElement(By.ClassName("header_label"));
            itemSauceLabsBackPack = driver.FindElement(By.Id("item_4_title_link"));
            addCardSauceBackPack = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            iconCard = driver.FindElement(By.ClassName("shopping_cart_link"));
        }

        public void verifiyHomePageIsDisplayed()
        {
            Assert.NotNull(header);
        }

        public void verifyItemHomePage(string item) 
        {
            Assert.Equal(item, itemSauceLabsBackPack.Text);
        }

        public void clickOnAddSauceLabsBackPack() 
        {
            addCardSauceBackPack.Click();
        }

        public void clickOnIconCard()
        {
            iconCard.Click();
        }
    }
}
