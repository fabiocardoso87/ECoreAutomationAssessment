using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Driver = new ChromeDriver(Environment.CurrentDirectory);
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
