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
        Account AddAmountByUsername(string Username, double QuotaCHF);

        [OperationContract]
        Account AddAmountByUID(int UID, double QuotaCHF);
  
        [OperationContract]
        Account AddUser(string Username, int CardID);

        [OperationContract]
        Account dimAmount(string Username, int QuotaToPrint);

    }
}
