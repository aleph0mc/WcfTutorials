﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MathService : IMathService
    {
        public int Add(MyNumbers Obj)
        {
            return Obj.Number1 + Obj.Number2;
        }

        public int Subtract(MyNumbers Obj)
        {
            return Obj.Number1 - Obj.Number2;
        }
    }
}
