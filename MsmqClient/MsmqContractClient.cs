using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MsmqContract;
using System.ServiceModel;

namespace MsmqClient
{
    class MsmqContractClient : ClientBase<IMsmqContract>, IMsmqContract
    {
        public MsmqContractClient(string endpoint)
            : base(endpoint)
        {
        }

        #region IMsmqContract Members

        public void SendMessage(string message)
        {
            Channel.SendMessage(message);
        }

        #endregion
    }
}
