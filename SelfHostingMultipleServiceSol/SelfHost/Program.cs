using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathServiceLibrary;
using CalcServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;
using static System.Console;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var serviceHost = new ServiceHost(typeof(MathService)))
            using (var serviceHost2 = new ServiceHost(typeof(CalcService)))
            {
                var basicHttpEndPoint1 = serviceHost.AddServiceEndpoint(typeof(IMathService),
                    new BasicHttpBinding(), "http://localhost:4444/MathService");

                var basicHttpEndPoint2 = serviceHost2.AddServiceEndpoint(typeof(ICalcService),
                    new BasicHttpBinding(), "http://localhost:5555/CalcService");

                serviceHost.Open();
                serviceHost2.Open();

                WriteLine("WCF service is running...");
                WriteLine("WCF Math Service running and listening on the below endpoints");
                //WriteLine("({0}, {1})", basicHttpEndPoint1.Address.ToString(), basicHttpEndPoint1.Binding.Name);
                WriteLine("Address: {0} Binding Name: {1}", basicHttpEndPoint1.Address.ToString(), basicHttpEndPoint1.Binding.Name);
                WriteLine("Address: {0} Binding Name: {1}", basicHttpEndPoint2.Address.ToString(), basicHttpEndPoint2.Binding.Name);

                WriteLine();
                WriteLine("Press any key to stop WCF Math Service");

                ReadKey();

                serviceHost.Close();
                serviceHost2.Close();
            }
        }
    }
}
