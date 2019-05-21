using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;
using static System.Console;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using
            (
                var serviceHost = new ServiceHost(typeof(MathService)))
            {
                var basicHttpEndPoint1 = serviceHost.AddServiceEndpoint(typeof(IMathService),
                    new BasicHttpBinding(), "http://localhost:4444/MathService");

                var basicHttpEndPoint2 = serviceHost.AddServiceEndpoint(typeof(IMathService),
                    new BasicHttpBinding(), "http://localhost:5555/MathService");

                var netTcpEndPoint = serviceHost.AddServiceEndpoint(typeof(IMathService),
                  new NetTcpBinding(), "net.tcp://localhost:6666/MathService");

                serviceHost.Open();

                WriteLine("WCF service is running...");
                WriteLine("WCF Math Service running and listening on the below endpoints");
                //WriteLine("({0}, {1})", basicHttpEndPoint1.Address.ToString(), basicHttpEndPoint1.Binding.Name);
                foreach (var endpoint in serviceHost.Description.Endpoints)
                {
                    WriteLine("Address: {0} Binding Name: {1}",
                        endpoint.Address.ToString(), endpoint.Binding.Name);
                }

                WriteLine();
                WriteLine("Press any key to stop WCF Math Service");

                ReadKey();

                serviceHost.Close();
            }
        }
    }
}
