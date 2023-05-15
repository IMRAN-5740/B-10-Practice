using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.DeclareInterface
{
    public interface IFlyable
    {
        public string FlyingSpeed { get; set; }
        public abstract string Fly();
    }
}
