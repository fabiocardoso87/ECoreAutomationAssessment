using EcoreAutomationProject.CSVHelper;
using LINQtoCSV;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoreAutomationProject
{    public class PageObjects : Base
    {

        const string mainUrl = "https://automation-sandbox-python-mpywqjbdza-uc.a.run.app/";
        
        public string GoToMainPage()
        {
            return Driver.Url = mainUrl;
        }

        public IWebElement GetInputUsername()
        {
            return Driver.FindElement(By.Name("username"));
        }
        public IWebElement GetInputPassword()
        {
            return Driver.FindElement(By.Name("password"));
        }
        public IWebElement GetLoginBtn()
        {
            return Driver.FindElement(By.Id("btnLogin"));
        }

        public void FillInputUsername(string username)
        {
            GetInputUsername().SendKeys(username);
        }
        public void FillInputPassword(string password)
        {
            GetInputPassword().SendKeys(password);
        }
        public void ClickLoginBtn()
        {
            GetLoginBtn().Click();
        }
        public void Login()
        {
            GetInputUsername();
            GetInputPassword();
            ClickLoginBtn();
        }

        public IWebElement GetErrorMsg()
        {
            return Driver.FindElement(By.XPath("//*[contains(@class,'alert')]"));

        }
        public void CheckErrorMessage(string errorMsg)
        {
            Assert.IsTrue(GetErrorMsg().Text.Contains(errorMsg));
        }
		public IWebElement LandingPageTitle()
		{
			return Driver.FindElement(By.XPath("//h2[contains(@class, 'mt-5') and contains(text(), 'Invoice List')]"));

		}
		
        public IWebElement InvoiceLink()
        {
            return Driver.FindElement(By.CssSelector("a[href='/invoice/0']"));
        }

        public void ClickInvoiceLink()
        {
            InvoiceLink().Click();
		}

		public IWebElement HotelName()
		{
			return Driver.FindElement(By.XPath("//h4[contains(@class, 'mt-5')]"));

		}

		public IWebElement InvoiceDate()
		{
            //var el = Driver.FindElement(By.XPath("//*[text()='14/01/2018']"));
            return Driver.FindElement(By.XPath("//*[text()=' 14/01/2018']"));

        }
		public IWebElement DueDate()
		{	
			return Driver.FindElement(By.XPath("//ul/li[2]"));
		}

		public IWebElement InvoiceNumber()
		{
			return Driver.FindElement(By.XPath("//h6[contains(@class, 'mt-2')]"));
		}

		public IWebElement BookingCode()
		{
			return Driver.FindElement(By.XPath("//*/table[1]//tr[1]/td[2]/preceding-sibling::td[contains(text(),'Booking Code')]"));
		}

		public IWebElement CustomerDetails()
		{
			return Driver.FindElement(By.XPath("//div/div/preceding-sibling::h5[contains(text(),'Customer Details')]//following-sibling::div/text()"));
		}

		public IWebElement Room()
		{
			return Driver.FindElement(By.XPath("//table[1]/tbody/tr[2]/td[2]"));
		}

		public IWebElement CheckIn()
		{
			return Driver.FindElement(By.XPath("//table[1]/tbody/tr[5]/td[2]"));
		}

		public IWebElement CheckOut()
		{
			return Driver.FindElement(By.XPath("//table[1]/tbody/tr[6]/td[2]"));
		}

		public IWebElement TotalStayCount()
		{
			return Driver.FindElement(By.XPath("//table[1]/tbody/tr[3]/td[2]"));
		}

		public IWebElement TotalStayAmount()
		{
			return Driver.FindElement(By.XPath("//table[1]/tbody/tr[4]/td[2]"));
		}

		public IWebElement DepositNow()
		{
			return Driver.FindElement(By.XPath("///table[2]/tbody/tr/td[1]"));
		}

		public IWebElement TaxandVAT()
		{
			return Driver.FindElement(By.XPath("//table[2]/tbody/tr/td[2]"));
		}

		public IWebElement TotalAmount()
		{
			return Driver.FindElement(By.XPath("//table[2]/tbody/tr/td[3]"));
		}
	}
}