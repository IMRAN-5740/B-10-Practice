using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Contracts
{
    public class HummingBird : Animal
    {
       

        public override string Speak()
        {
            return "HummingBird is Speaking..... Fas Fas";
        }
    }
}
