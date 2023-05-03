using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoreAutomationProject
{
	public class Helper
	{
		public Base bs = new();
		PageObjects page = new();
		public  void IsLandingPageDisplayed(string msg)
		{
			Assert.IsTrue(page.LandingPageTitle().Text.Contains(msg));
		}
		public void SwitchToTab()
		{
			Base.Driver.SwitchTo().Window(Base.Driver.WindowHandles.Last());
		}
	}
}
