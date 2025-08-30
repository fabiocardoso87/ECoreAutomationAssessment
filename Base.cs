using OpenQA.Selenium;
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

            }
            catch (DriverServiceNotFoundException er)
            {
                Console.WriteLine(er.Message);
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (Driver != null)
            {
                Driver.Close();
                Driver.Dispose();
            }
        }
    }
}
