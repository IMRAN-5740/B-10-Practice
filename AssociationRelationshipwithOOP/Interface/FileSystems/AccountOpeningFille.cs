using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.FileSystems
{
    public class AccountOpeningFille:File
    {
        public string AccountNum { get; set; }
        public string AccountName { get; set; }
        public override string GetInfo()
        {
            return base.GetInfo()+$"Account No :{AccountNum} Account Name : {AccountName}\n";
        }

    }
}
