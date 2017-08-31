using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace MsmqContract
{
    [ServiceContract]
    public interface IMsmqContract
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
    }
}
