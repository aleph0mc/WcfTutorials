using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    // Default session behavior is PerSession
    // PerCall won't retain any data
    // Single: the data is retained for all the clients (similar to an application varable)
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MathService : IMathService
    {
        private int _counter;
        public int Add(MyNumbers Obj)
        {
            _counter++;
            return Obj.Number1 + Obj.Number2;
        }

        public int Subtract(MyNumbers Obj)
        {
            _counter++;
            return Obj.Number1 - Obj.Number2;
        }

        public int GetCounter()
        {
            return _counter;
        }
    }
}
