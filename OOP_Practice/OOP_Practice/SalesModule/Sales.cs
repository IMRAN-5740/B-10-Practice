using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.SalesModule
{
    public class Sales
    {
        public int SalesNum { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string SalesDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public string GetInvoice()
        {
            string inVoice = "";
            inVoice += $"Sales Num :{SalesNum}\n";
            inVoice += $"CustomerName  :{CustomerName}\n";
            inVoice += $"Customer Contact  :{CustomerContact}\n";
            inVoice += $"ProductName  :{ProductName}\n";
            inVoice += $"Product Quantity  :{Quantity}\n";
            inVoice += $"UnitPrice  :{UnitPrice}\n";
            inVoice += $"TotalPrice  :{Quantity*UnitPrice}\n";

            return inVoice;
        }

    }
   
}
