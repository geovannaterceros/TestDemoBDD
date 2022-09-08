using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestDemoBDD.Utilities
{
    public class DriveManager
    {
        private static DriveManager instance = null;
        private static IWebDriver webDriver;

        private DriveManager() 
        {
            webDriver = new ChromeDriver(@"G:\SeleniumWebDrivers");
        }

        public static DriveManager getInstance()
        {
            if (instance == null)
            {
                instance = new DriveManager();
            }
            return instance;
        }

        public IWebDriver getDriver()
        {
            return webDriver;
        }

    }
}
