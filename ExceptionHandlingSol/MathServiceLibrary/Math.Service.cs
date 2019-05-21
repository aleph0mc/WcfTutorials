using System;
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

        public int Divide(MyNumbers Obj)
        {
            int result = 0;

            // In WCF .Net Exceptions are not recommended
            // Best practise is Fault exceptions (Fault contracts)
            try
            {
                if (Obj.Number2 > 100)
                    throw new Exception("Wrong Value");

                result = Obj.Number1 / Obj.Number2;
            }
            //catch (System.DivideByZeroException dex)
            //{
            //    throw new DivideByZeroException(dex.Message);
            //}
            //catch (Exception ex)
            //{
            //    //throw new Exception(ex.Message);
            //    if (ex.Message.StartsWith("Wrong"))
            //        throw new FaultException("Value of divisor cannot be above 100!!!!", new FaultCode("DivisorAbove100"));
            //    else
            //        throw new FaultException("Division by zero!!!!", new FaultCode("DivisorIsZero"));
            //}
            catch (Exception ex)
            {
                var df = new DivisionFault
                {
                    Method = "Divide",
                    Reason = "Divisor value cannot be zero",
                    Message = ex.Message
                };

                throw new FaultException<DivisionFault>(df);
            }


            return result;
        }

        public void DivideOneWay(MyNumbers Obj)
        {
            Divide(Obj);
        }
    }
}
