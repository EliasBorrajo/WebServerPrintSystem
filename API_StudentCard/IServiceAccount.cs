using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API_StudentCard
{
    [ServiceContract]
    public interface IServiceAccount
    {
        [OperationContract]
        Account AddAmountByUsername(string Username, double QuotaCHF, string Services);

        [OperationContract]
        Account AddAmountByUID(string UID, double QuotaCHF, string Services);

        [OperationContract]
    }
}
