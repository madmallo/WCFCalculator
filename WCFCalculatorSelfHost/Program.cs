using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFCalculator;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCFCalculatorSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
            Uri HttpUrl = new Uri("http://localhost:8090/VediamoSeFunge");

            //Create ServiceHost
            ServiceHost Host = new ServiceHost(typeof(WCFCalculator.Service1), HttpUrl);

            //Add a service endpoint
            Host.AddServiceEndpoint(typeof(WCFCalculator.IService1), new WSHttpBinding(), "");

            //Enable metadata exchange
            ServiceMetadataBehavior SMB = new ServiceMetadataBehavior();
            SMB.HttpGetEnabled = true;
            Host.Description.Behaviors.Add(SMB);

            //Start the Service
            Host.Open();
            Console.WriteLine("Service is host at {0}", DateTime.Now.ToString());
            Console.WriteLine("Host is running... (press any key to stop)");
            Console.ReadKey();
        }
    }
}
