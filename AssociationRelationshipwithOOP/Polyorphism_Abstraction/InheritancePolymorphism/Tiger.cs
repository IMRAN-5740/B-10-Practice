using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyorphism_Abstraction.InheritancePolymorphism
{
    public class Tiger:Animal
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
            return "TIger is Speaking----Halum Halum";
        }
    }
}
