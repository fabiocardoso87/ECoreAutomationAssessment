using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace EcoreAutomationProject
{
    [TestClass]
    public class Base
    {
        public static IWebDriver Driver { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                Driver = new ChromeDriver();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Driver.Manage().Window.Maximize();

            }
            catch (DriverServiceNotFoundException er)
            {
                Console.WriteLine(er.Message);
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Driver?.Quit();
        }
    }
}
