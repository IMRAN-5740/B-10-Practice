﻿using InterfaceExample.DeclareInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Contracts
{
    public class Doel :Bird, IFlyable
    {
        public string FlyingSpeed { get; set; }

        public string Fly()
        {
            return "Doel is Flying";
        }

        public override string Speak()
        {
            return "Doel is Charping";
        }
    }
}
