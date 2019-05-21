using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    /// <summary>
    /// This Servive supports a Duplex Exchange Pattern
    /// The Callback interface is specified
    /// </summary>
    [ServiceContract(CallbackContract = typeof(IMathServiceCallback))]
    public interface IMathService
    {
        // Request/Reply (default pettern)
        // --------------------------------------

        [OperationContract]
        int Add(MyNumbers Obj);

        [OperationContract]
        int Subtract(MyNumbers Obj);

        // ---------------------------------------

        // One way Pattern - Fire and forget
        // ---------------------------------------

        [OperationContract(IsOneWay = true)]
        void SignIn(string UserName);

        [OperationContract(IsOneWay = true)]
        void SignOut(string UserName);

        // ---------------------------------------

        // Duplex Exchange Pattern / Fire and remind me
        // ---------------------------------------

        [OperationContract(IsOneWay = true)]
        void StartPrintingLogFiles(string Message);


        // ---------------------------------------
    }

    /// <summary>
    /// Required when implementing the Duplex Exchange Pattern
    /// </summary>
    public interface IMathServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void NotifyClientWhenPrintDone(string Message);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "MathServiceLibrary.ContractType".
    [DataContract]
    public class MyNumbers
    {
        [DataMember]
        public int Number1 { get; set; }

        [DataMember]
        public int Number2 { get; set; }
    }
}
