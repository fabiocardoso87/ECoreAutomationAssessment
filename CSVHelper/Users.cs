using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoreAutomationProject.CSVHelper
{
    public class Users
    {
        [CsvColumn(Name = "Username")]
        public string Username { get; set; }
        
        [CsvColumn(Name = "Password")]
        public string Password { get; set; }
    }
}
