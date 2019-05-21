using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

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

        public void SignIn(string UserName)
        {
            System.Threading.Thread.Sleep(5000);
            var str = new StringWriter();
            str.WriteLine("{0} has loaded the form at {1:t}", UserName, DateTime.Now.ToString("hh:mm:ss"));

            File.AppendAllText(@"c:\temp\wcfMessageExchPtrnLog.txt", str.ToString());
        }

        public void SignOut(string UserName)
        {
            System.Threading.Thread.Sleep(5000);
            var str = new StringWriter();
            str.WriteLine("{0} has closed the form at {1:t}", UserName, DateTime.Now.ToString("hh:mm:ss"));

            File.AppendAllText(@"c:\temp\wcfMessageExchPtrnLog.txt", str.ToString());
        }

        public void StartPrintingLogFiles(string Message)
        {
            IMathServiceCallback msCallback = OperationContext.Current.GetCallbackChannel<IMathServiceCallback>();

            // Print code here....

            System.Threading.Thread.Sleep(5000);
            msCallback.NotifyClientWhenPrintDone(Message);
        }
    }
}
