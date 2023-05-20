using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Contracts
{
    public class Duck : Animal
    {
       

        public override string Speak()
        {
            return "Duck is Speaking ..Pack Pack";
        }
    }
}
