using EcoreAutomationProject.CSVHelper;
using OpenQA.Selenium;
using System.ComponentModel.DataAnnotations;

namespace EcoreAutomationProject
{
    [TestClass]
    public class Tests : PageObjects
    {
		private readonly CSVReader csv = new();
		private readonly Helper helper = new();

		[TestMethod]
        public void TC001_Login_Positive()
        {
            GoToMainPage();
            csv.ReadCSVFile(CSVReader.loginPositive);
            Login();
            helper.IsLandingPageDisplayed("Invoice List");
        }

        [TestMethod]
        public void TC002_Login_Negative()
        {
            GoToMainPage();
            csv.ReadCSVFile(CSVReader.loginNegative);
		}

		[TestMethod]
		public void TC003_Validate_Invoice_Details()
        {
			GoToMainPage();
			csv.ReadCSVFile(CSVReader.loginPositive);
			Login();
            ClickInvoiceLink();
            helper.SwitchToTab();
            csv.ReadCSVFile(CSVReader.invoiceDetails);

			Thread.Sleep(2000);

		}
	}
}