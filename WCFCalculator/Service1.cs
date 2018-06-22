using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalculator
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    //public delegate int Del(int P1, int P2);

    public class Service1 : IService1
    {
        //public int Somma(int Num1, int Num2) => Num1 + Num2;
        //public Del Somma = (int Num1, int Num2) => Num1 + Num2;
        public int Somma(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public int Sottrazione(int Num1, int Num2)
        {
            return Num1 - Num2;
        }
        public int Moltiplicazione(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
        public int Divisione(int Num1, int Num2)
        {
            if(Num2 != 0) return Num1 / Num2;
            return 0;
        }
    }
}
