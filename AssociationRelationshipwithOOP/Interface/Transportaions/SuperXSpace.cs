using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Transportaions
{
    public class SuperXSpace : IFlyable
    {
        public string Fly()
        {
            return "SuperXSpace is flying";
        }
    }
}
