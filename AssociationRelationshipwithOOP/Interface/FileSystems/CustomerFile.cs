using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.FileSystems
{
    public class CustomerFile:File
    {
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo()+$"Customer No : {CustomerNo} Customer Name : {CustomerName} Ship to  :{ShippingAddress}\n";
        }
    }
}
