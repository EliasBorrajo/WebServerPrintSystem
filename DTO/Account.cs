using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public int AccountId { get; set; } 

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string UID { get; set; }

        [DataMember]
        public double AccountAmount { get; set; }

        [DataMember]
        public int NewQuotaFeuille { get; set; }

        [DataMember]
        public List<Transaction> ListeTransac { get; set; }

    }
}
