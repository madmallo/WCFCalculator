﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalculator
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Somma(int Num1, int Num2);

        [OperationContract]
        int Sottrazione(int Num1, int Num2);

        [OperationContract]
        int Moltiplicazione(int Num1, int Num2);

        [OperationContract]
        int Divisione(int Num1, int Num2);

        // TODO: aggiungere qui le operazioni del servizio
    }

    // Per aggiungere tipi compositi alle operazioni del servizio utilizzare un contratto di dati come descritto nell'esempio seguente.
    // È possibile aggiungere file XSD nel progetto. Dopo la compilazione del progetto è possibile utilizzare direttamente i tipi di dati definiti qui con lo spazio dei nomi "WCFCalculator.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
