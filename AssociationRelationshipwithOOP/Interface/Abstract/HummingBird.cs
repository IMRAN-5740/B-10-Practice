using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract
{
    public class HummingBird : Animal
    {
        public override string Eat()
        {
            throw new NotImplementedException();
        }

        public override string Move()
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            return "HummingBird is Speaking..... Fas Fas";
        }
    }
}
