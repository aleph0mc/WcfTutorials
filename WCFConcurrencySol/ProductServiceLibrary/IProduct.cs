using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    // WCF default behavior: one request at a time
    [ServiceContract]
    public interface IProduct
    {
        [OperationContract(IsOneWay = true)]
        void AddCategory(string CategoryName);
    }
}
