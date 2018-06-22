using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFCalculatorSelfHostProxy;

namespace WCFCalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1;
            int N2;
            WCFCalculatorSelfHostProxy.WCFCalculatorSelfHostProxy Proxy = new WCFCalculatorSelfHostProxy.WCFCalculatorSelfHostProxy();
            Console.WriteLine("Client is running at {0}", DateTime.Now.ToString());
            Console.Write("Get number 1: ");
            N1 = Convert.ToInt32(Console.ReadKey());
            Console.Write("Get number 2: ");
            N2 = Convert.ToInt32(Console.ReadKey());
            Console.WriteLine("\n");
            Console.WriteLine("Somma: {0} + {1} = {2}", N1, N2, Proxy.Somma(N1, N2));
            Console.WriteLine("Sottrazione: {0} - {1} = {2}", N1, N2, Proxy.Sottrazione(N1, N2));
            Console.WriteLine("Moltiplicazione: {0} * {1} = {2}", N1, N2, Proxy.Moltiplicazione(N1, N2));
            Console.WriteLine("Divisione: {0} / {1} = {2}", N1, N2, Proxy.Divisione(N1, N2));
        }
    }
}
