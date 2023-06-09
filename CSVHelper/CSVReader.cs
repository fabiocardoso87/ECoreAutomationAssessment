﻿using LINQtoCSV;
using OpenQA.Selenium.DevTools.V110.Debugger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoreAutomationProject.CSVHelper
{
	public class CSVReader : PageObjects
	{
		static readonly string locationFolder = Environment.CurrentDirectory + "\\DataTables\\";
		public const string loginPositive = "loginPositive.csv";
		public const string loginNegative = "loginNegative.csv";
		public const string invoiceDetails = "invoice.csv";


		public void ReadCSVFile(string dataTable)
		{
			var csvFileDescription = new CsvFileDescription
			{
				SeparatorChar = ';'
			};

			var csvContext = new CsvContext();
			
			switch (dataTable)
			{
				case loginPositive:
					{
						var users = csvContext.Read<Users>(locationFolder + dataTable, csvFileDescription);
						foreach (var user in users)
						{
							FillInputUsername(user.Username);
							FillInputPassword(user.Password);
						}
						break;
					}
				case loginNegative:
					{
						var users = csvContext.Read<Users>(locationFolder + dataTable, csvFileDescription);
						foreach (var user in users)
						{
							FillInputUsername(user.Username);
							FillInputPassword(user.Password);
							Login();
							CheckErrorMessage("Wrong username or password.");
						}
						break;
					}
				case invoiceDetails:
					{
						var invoice = csvContext.Read<Invoice>(locationFolder + dataTable, csvFileDescription);
						foreach (var value in invoice)
						{
							Assert.AreEqual(value.HotelName, HotelName().Text);
							Assert.AreEqual(value.InvoiceDate, InvoiceDate().Text);
							Assert.AreEqual(value.DueDate, DueDate().Text);
							Assert.IsTrue(InvoiceDate().Text.Contains(value.InvoiceNumber));
							Assert.AreEqual(value.BookingCode, BookingCode().Text);
							Assert.AreEqual(value.CustomerDetails, CustomerDetails().Text);
							Assert.AreEqual(value.Room, Room().Text);
							Assert.AreEqual(value.CheckIn, CheckIn().Text);
							Assert.AreEqual(value.CheckOut, CheckOut().Text);
							Assert.AreEqual(value.TotalStayCount, TotalStayCount().Text);
							Assert.AreEqual(value.TotalStayAmount, TotalStayAmount());
							Assert.AreEqual(value.DepositNow, DepositNow().Text);
							Assert.AreEqual(value.TaxandVAT, TaxandVAT().Text);
							Assert.AreEqual(value.TotalAmount, TotalAmount().Text);
						}
						break;
					}
				default:
					{
						throw new LINQtoCSVException("Invalid or non-existent file");
					}
			}
		}
	}
}