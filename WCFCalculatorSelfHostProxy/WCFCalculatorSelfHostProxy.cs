using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFCalculator;

namespace WCFCalculatorSelfHostProxy
{
    //WCF create proxy for IService1 using ClientBase
    public class WCFCalculatorSelfHostProxy : ClientBase<IService1>, IService1
    {
        public int Somma(int Num1, int Num2)
        {
            //call base to do function
            return base.Channel.Somma(Num1, Num2);
        }
        public int Sottrazione(int Num1, int Num2)
        {
            //call base to do function
            return base.Channel.Sottrazione(Num1, Num2);
        }
        public int Moltiplicazione(int Num1, int Num2)
        {
            //call base to do function
            return base.Channel.Moltiplicazione(Num1, Num2);
        }
        public int Divisione(int Num1, int Num2)
        {
            //call base to do function
            return base.Channel.Divisione(Num1, Num2);
        }
    }
}
