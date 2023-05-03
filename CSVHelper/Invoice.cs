using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoreAutomationProject.CSVHelper
{
    public class Invoice
    {
		[CsvColumn(Name = "HotelName")]
        public string HotelName { get; set; }
        
        [CsvColumn(Name = "InvoiceDate")]
        public string InvoiceDate { get; set; }

		[CsvColumn(Name = "DueDate")]
		public string DueDate { get; set; }

		[CsvColumn(Name = "InvoiceNumber")]
		public string InvoiceNumber { get; set; }

		[CsvColumn(Name = "BookingCode")]
		public string BookingCode { get; set; }

		[CsvColumn(Name = "CustomerDetails")]
		public string CustomerDetails { get; set; }

		[CsvColumn(Name = "Room")]
		public string Room { get; set; }

		[CsvColumn(Name = "CheckIn")]
		public string CheckIn { get; set; }

		[CsvColumn(Name = "CheckOut")]
		public string CheckOut { get; set; }

		[CsvColumn(Name = "TotalStayCount")]
		public string TotalStayCount { get; set; }

		[CsvColumn(Name = "TotalStayAmount")]
		public string TotalStayAmount { get; set; }

		[CsvColumn(Name = "DepositNow")]
		public string DepositNow { get; set; }

		[CsvColumn(Name = "Tax&VAT")]
		public string TaxandVAT { get; set; }

		[CsvColumn(Name = "TotalAmount")]
		public string TotalAmount { get; set; }

	}
}
