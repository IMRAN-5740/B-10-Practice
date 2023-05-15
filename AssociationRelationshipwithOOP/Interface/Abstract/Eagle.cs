using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract
{
    public class Eagle : Animal
    {
        public override string Eat()
        {
            throw new NotImplementedException();
        }

        //public string Fly()
        //{
        //    return "Eagle is Flying";
        //}

        public override string Move()
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            return "Eagle is Speaking ..Kuuu Kuuu Kuu";
        }
    }
}
